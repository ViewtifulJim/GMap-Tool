using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using System.Data.Entity;
using MongoDB.Driver.Core.Authentication;
using MongoDB.Bson.IO;
using Newtonsoft.Json;
using System.Threading.Tasks.Sources;

namespace GMapTool
{
    public partial class GMapToolMainForm : Form
    {

        string connectionString;
        string databaseName;
        string collectionName;
        IMongoCollection<CustomDataRetrieval> customCollection;
        IMongoCollection<ShipwreckDataRetrieval> shipwreckCollection;
        IMongoDatabase db;


        public GMapToolMainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            cboBoxDataset.SelectedItem = "Custom Data";
        }

        private void GMapToolMainForm_Load(object sender, EventArgs e)
        {
            establishConnection();
            gMapLoad();
            gMap.Zoom = gMap.MinZoom;
            updateToolTips();
            populateDataGrid();
            gMap.Refresh();
        }

        private void gMap_OnMapZoomChanged()
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxLatitudeY.Text = "";
            txtBoxLongitudeX.Text = "";
            txtBoxMarkerName.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBoxLatitudeY.Text == "" || txtBoxLongitudeX.Text == "" || txtBoxMarkerName.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            double latitude = Convert.ToDouble(txtBoxLatitudeY.Text);
            double longitude = Convert.ToDouble(txtBoxLongitudeX.Text);
            string markerName = txtBoxMarkerName.Text;

            if (collectionName == "shipwrecks")
            {
                var shipwreckAddress = new ShipwreckDataRetrieval
                {
                    FeatureType = markerName,
                    Coordinates = new List<double>() { longitude, latitude } // Longitude first, then latitude
                };
                shipwreckCollection.InsertOne(shipwreckAddress);
            }
            else
            {
                var customAddress = new CustomDataRetrieval
                {
                    Name = markerName,
                    Coordinates = new List<double>() { latitude, longitude } // Latitude first, then longitude
                };
                customCollection.InsertOne(customAddress);
            }

            updateToolTips();
            populateDataGrid();

            txtBoxLatitudeY.Text = "";
            txtBoxLongitudeX.Text = "";
            txtBoxMarkerName.Text = "";
        }

        private void establishConnection()
        {
            MongoClient dbClient = new MongoClient(connectionString);
            db = dbClient.GetDatabase(databaseName);

            if (collectionName == "shipwrecks")
            {
                this.shipwreckCollection = db.GetCollection<ShipwreckDataRetrieval>(collectionName);
            }
            else
            {
                this.customCollection = db.GetCollection<CustomDataRetrieval>(collectionName);
            }

        }
        
        private void gMapLoad()
        {
            gMap.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMap.ShowCenter = false;
        }

       
        public IEnumerable<BsonDocument> getData()
        {

            if (collectionName == "shipwrecks")
            {
                // Access the collection
                var collection = db.GetCollection<BsonDocument>(collectionName);

                // Define the projection to include only specific fields
                var projection = Builders<BsonDocument>.Projection
                    .Include("feature_type")
                    .Include("coordinates");

                // Retrieve data from the collection with the specified projection
                var documents = collection.Find(Builders<BsonDocument>.Filter.Empty)
                                          .Project(projection)
                                          .ToList();
                return documents;
            }
            else
            {
                var collection = db.GetCollection<BsonDocument>(collectionName);
                var documents = collection.Find(Builders<BsonDocument>.Filter.Empty).ToList();

                return documents;
            }

            //return documents;
        }

        private void populateDataGrid()
        {
            dtaGridView.Rows.Clear();

            var documents = getData();
            double x, y;
            
            foreach (var document in documents)
            {
                
                DataGridViewRow row = new DataGridViewRow();

                
                foreach (var element in document.Elements)
                {
                    
                    if (element.Value.IsBsonArray)
                    {
                        string trimmedArray = element.Value.ToString().Trim('[', ']');
                        string[] values = trimmedArray.Split(',');

                        foreach (var value in values)
                        {
                            DataGridViewCell cell = new DataGridViewTextBoxCell();
                            cell.Value = value;
                            row.Cells.Add(cell);
                        }

                        y = Convert.ToDouble(values[0]);
                        x = Convert.ToDouble(values[1]);

                    }
                    else
                    {
                        // Add a new cell to the row for other elements
                        DataGridViewCell cell = new DataGridViewTextBoxCell();

                        cell.Value = element.Value.ToString(); // Convert the element value to string
                        row.Cells.Add(cell);
                    }


                }

                // Add the row to the data grid
                dtaGridView.Rows.Add(row);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtaGridView.SelectedCells.Count > 0)
            {

                int rowIndex = dtaGridView.SelectedCells[0].RowIndex;

                string documentId = dtaGridView.Rows[rowIndex].Cells["ColID"].Value.ToString();

                if (collectionName == "shipwrecks")
                {
                    var filter = Builders<ShipwreckDataRetrieval>.Filter.Eq("_id", ObjectId.Parse(documentId));

                    try
                    {
                        var result = shipwreckCollection.DeleteOne(filter);
                        if (result.DeletedCount == 0)
                        {
                            MessageBox.Show("No matching document found for deletion.");
                        }
                        else
                        {
                            MessageBox.Show("Document deleted successfully.");
                            gMap.Overlays.Clear();
                            populateDataGrid();
                            updateToolTips();
                            gMap.Invalidate();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred during deletion: " + ex.Message);
                    }
                }
                else
                {
                    var filter = Builders<CustomDataRetrieval>.Filter.Eq("_id", ObjectId.Parse(documentId));
                    try
                    {
                        var result = customCollection.DeleteOne(filter);
                        if (result.DeletedCount == 0)
                        {
                            MessageBox.Show("No matching document found for deletion.");
                        }
                        else
                        {
                            MessageBox.Show("Document deleted successfully.");
                            gMap.Overlays.Clear();
                            populateDataGrid();
                            updateToolTips();
                            gMap.Invalidate();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("An error occurred during deletion: " + ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBoxLatitudeY.Text == "" || txtBoxLongitudeX.Text == "" || txtBoxMarkerName.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {

                if (dtaGridView.SelectedCells.Count > 0)
                {
                    if(collectionName != "shipwrecks")
                    {

                    
                        int rowIndex = dtaGridView.SelectedCells[0].RowIndex;

                    
                        string documentId = dtaGridView.Rows[rowIndex].Cells["ColID"].Value.ToString();

                    
                        var filter = Builders<CustomDataRetrieval>.Filter.Eq("_id", ObjectId.Parse(documentId));
                        var document = customCollection.Find(filter).FirstOrDefault();

                        if (document != null)
                        {
                        
                            document.Name = txtBoxMarkerName.Text;
                            document.Coordinates = new List<double> { Convert.ToDouble(txtBoxLatitudeY.Text), Convert.ToDouble(txtBoxLongitudeX.Text) };
           
                            var result = customCollection.ReplaceOne(filter, document);

                            if (result.IsAcknowledged && result.ModifiedCount > 0)
                            {
                                MessageBox.Show("Document updated successfully.");
                                ClearTextBoxes();
                                gMap.Overlays.Clear();
                                populateDataGrid();
                                updateToolTips();
                                gMap.Invalidate();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update document.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Document not found in the collection.");
                        }

                    }
                    else
                    {

                        int rowIndex = dtaGridView.SelectedCells[0].RowIndex;

                        string documentId = dtaGridView.Rows[rowIndex].Cells["ColID"].Value.ToString();

                        var filter = Builders<ShipwreckDataRetrieval>.Filter.Eq("_id", ObjectId.Parse(documentId));
                        var document = shipwreckCollection.Find(filter).FirstOrDefault();

                        if (document != null)
                        {
                            document.FeatureType = txtBoxMarkerName.Text;
                            document.Coordinates = new List<double> { Convert.ToDouble(txtBoxLongitudeX.Text), Convert.ToDouble(txtBoxLatitudeY.Text) };

                            var result = shipwreckCollection.ReplaceOne(filter, document);

                            if (result.IsAcknowledged && result.ModifiedCount > 0)
                            {
                                MessageBox.Show("Document updated successfully.");
                                ClearTextBoxes();
                                gMap.Overlays.Clear();
                                populateDataGrid();
                                updateToolTips();
                                gMap.Invalidate();
                            }
                            else
                            {
                                MessageBox.Show("Failed to update document.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Document not found in the collection.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.");
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the GMapTool!\n\n" +
                            "To add a marker, enter the latitude and longitude coordinates in the respective text boxes.\n" +
                            "You can also enter a name for the marker in the 'Marker Name' text box.\n" +
                            "Click the 'Add' button to place the marker on the map and save the data to the database.\n\n" +
                            "To update a marker, select the row in the data grid corresponding to the marker you want to update.\n" +
                            "Modify the latitude, longitude, or name fields as needed, then click the 'Update' button.\n\n" +
                            "To delete a marker, select the row in the data grid corresponding to the marker you want to delete.\n" +
                            "Click the 'Delete' button to remove the marker from the map and the database.\n\n" +
                            "Click the 'Clear' button to clear the text boxes and start fresh.\n\n" +
                            "Enjoy using the GMapTool!\n\n" +
                            "Created by:\n" +
                            "James Williams\n" + 
                            "14048787");
        }

        private void updateToolTips()
        {

            
            var documents = getData();

            
            GMapOverlay markersOverlay = new GMapOverlay("markers");

            if (collectionName == "TestCollection")
            {
                foreach (var document in documents)
                {
                    BsonValue coordinatesValue;
                    if (document.TryGetValue("coordinates", out coordinatesValue) && coordinatesValue.IsBsonArray)
                    {
                        var coordinatesArray = coordinatesValue.AsBsonArray;
                        if (coordinatesArray.Count == 2)
                        {
                            double longitude = coordinatesArray[0].AsDouble;
                            double latitude = coordinatesArray[1].AsDouble;

                        
                            GMapMarker marker = new GMarkerGoogle(new PointLatLng(longitude, latitude), GMarkerGoogleType.pink);

                        
                            BsonValue nameValue;
                            if (document.TryGetValue("Name", out nameValue))
                            {
                                marker.ToolTipText = nameValue.AsString;
                            }

                            markersOverlay.Markers.Add(marker);
                        }
                    }
                }
            }
            else
            {
                foreach (var document in documents)
                {
                    BsonValue coordinatesValue;
                    if (document.TryGetValue("coordinates", out coordinatesValue) && coordinatesValue.IsBsonArray)
                    {
                        var coordinatesArray = coordinatesValue.AsBsonArray;
                        if (coordinatesArray.Count == 2)
                        {
                            double longitude = coordinatesArray[1].AsDouble;
                            double latitude = coordinatesArray[0].AsDouble;


                            GMapMarker marker = new GMarkerGoogle(new PointLatLng(longitude, latitude), GMarkerGoogleType.blue);


                            BsonValue nameValue;
                            if (document.TryGetValue("feature_type", out nameValue))
                            {
                                marker.ToolTipText = nameValue.AsString;
                            }

                            markersOverlay.Markers.Add(marker);
                        }
                    }
                }
            }


            gMap.Overlays.Add(markersOverlay);
        }

        private void dtaGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtaGridView.Rows.Count)
            {
                double latitude;
                double longitude;

                // Check if cell values are not null or empty
                if (dtaGridView.Rows[e.RowIndex].Cells["ColX"].Value != null &&
                    dtaGridView.Rows[e.RowIndex].Cells["ColY"].Value != null &&
                    !string.IsNullOrEmpty(dtaGridView.Rows[e.RowIndex].Cells["ColX"].Value.ToString()) &&
                    !string.IsNullOrEmpty(dtaGridView.Rows[e.RowIndex].Cells["ColY"].Value.ToString()))
                {
                    if (double.TryParse(dtaGridView.Rows[e.RowIndex].Cells["ColX"].Value.ToString(), out latitude) &&
                        double.TryParse(dtaGridView.Rows[e.RowIndex].Cells["ColY"].Value.ToString(), out longitude))
                    {
                        if (collectionName == "shipwrecks")
                        {
                            gMap.Position = new PointLatLng(latitude, longitude);
                        }
                        else
                        {
                            gMap.Position = new PointLatLng(longitude, latitude);
                        }

                        // Adjust the zoom level as needed
                        gMap.Zoom = gMap.MaxZoom - 6;
                    }
                    else
                    {
                        MessageBox.Show("Invalid coordinates.");
                    }
                }
                else
                {
                    MessageBox.Show("Cell values are empty or null.");
                }
            }
        }

        private void GMapToolMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void gMap_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            PointLatLng point = gMap.FromLocalToLatLng(e.X, e.Y);

            
            using (MarkerNameForm markerNameForm = new MarkerNameForm())
            {
                
                DialogResult result = markerNameForm.ShowDialog();

                
                if (result == DialogResult.OK)
                {
                    string markerName = markerNameForm.MarkerName;

                    if (!string.IsNullOrEmpty(markerName))
                    {

                        if (collectionName == "shipwrecks")
                        {
                         
                            var newMarker = new ShipwreckDataRetrieval { FeatureType = markerName, Coordinates = new List<double>() { point.Lng, point.Lat } };
                            shipwreckCollection.InsertOne(newMarker);

                        }
                        else
                        {
                            var newMarker = new CustomDataRetrieval { Name = markerName, Coordinates = new List<double>() { point.Lat, point.Lng } };
                            customCollection.InsertOne(newMarker);
                        }
                        
                        updateToolTips();
                        populateDataGrid();
                    }
                }
            }
        }

        private void cboBoxDataset_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDataset = cboBoxDataset.SelectedItem.ToString();

            switch (selectedDataset)
            {
                case "Custom Data":
            
                    connectionString = "mongodb+srv://ViewtifulJim:Password5566@unicluster.itff1b6.mongodb.net/?retryWrites=true&w=majority&appName=UniCluster";
                    databaseName = "TestDatabase";
                    collectionName = "TestCollection";
                    lblControlPanel.Text = "Custom Map";
                    gMap.Overlays.Clear();
                    break;
                case "Shipwreck Data":

                    connectionString = "mongodb+srv://ViewtifulJim:Password5566@unicluster.itff1b6.mongodb.net/?retryWrites=true&w=majority&appName=UniCluster";
                    databaseName = "sample_geospatial";
                    collectionName = "shipwrecks";
                    lblControlPanel.Text = "Shipwreck Map";
                    gMap.Overlays.Clear();
                    break;
                default:

                    MessageBox.Show("Unknown dataset selected.");
                    return;
            }

            establishConnection();
            updateToolTips();
            populateDataGrid();
        }

        private void ClearTextBoxes()
        {
            txtBoxLatitudeY.Text = "";
            txtBoxLongitudeX.Text = "";
            txtBoxMarkerName.Text = "";
        }
    }
}
