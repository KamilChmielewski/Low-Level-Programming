using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using OfflineEditor;

namespace OfflineEditor
{
    
    public partial class Form1 : Form
    {
        //Values needed to create a sphere
        Vec3f Center; //Also known as position
        Vec3f Velocity;
        float Radius;
        Vec3f SurfaceColor, EmissionColor;
        float Transparency, Reflection;
        float RadiusIncrement;
        //A list of Sphere objects to later write to JSON file
        List<Sphere> spheres;

        int sphereCounter = 0;

        public Form1()
        {
           spheres = new List<Sphere>();
           InitializeComponent();
        }

        private void PostionXChanged(object sender, EventArgs e)
        {
            Center.x = (float)PosX.Value;
        }

        private void PostionYChanged(object sender, EventArgs e)
        {
            Center.y = (float)PosY.Value;
        }

        private void PositionZChanged(object sender, EventArgs e)
        {
            Center.z = (float)PosZ.Value;
        }

        private void VelocityXChanged(object sender, EventArgs e)
        {
            Velocity.x = (float)VelX.Value;
        }

        private void VelocityYChanged(object sender, EventArgs e)
        {
            Velocity.y = (float)VelY.Value;
        }
        private void VelocityZChanged(object sender, EventArgs e)
        {
            Velocity.z = (float)VelZ.Value;
        }

        private void SurfaceRChanged(object sender, EventArgs e)
        {
            SurfaceColor.x = (float)SurfR.Value;
        }

        private void SurfaceGChanged(object sender, EventArgs e)
        {
            SurfaceColor.y = (float)SurfG.Value;
        }

        private void SurfaceBChanged(object sender, EventArgs e)
        {
            SurfaceColor.z = (float)SurfB.Value;
        }

        private void EmissionRChanged(object sender, EventArgs e)
        {
            EmissionColor.x = (float)EmissionColR.Value;
        }

        private void EmissionGChanged(object sender, EventArgs e)
        {
            EmissionColor.y = (float)EmissionColG.Value;
        }

        private void EmissionBChanged(object sender, EventArgs e)
        {
            EmissionColor.z = (float)EmissionColB.Value;
        }

        private void RadiusHasChanged(object sender, EventArgs e)
        {
            Radius = (float)RaduisNum.Value;
        }

        private void TransparencyHasChanged(object sender, EventArgs e)
        {
            Transparency = (float)TransparencyNum.Value;
        }

        private void ReflectionHasChanged(object sender, EventArgs e)
        {
            Reflection = (float)ReflectionNum.Value;
        }

        private void RadiusIncrementHasChanged(object sender, EventArgs e)
        {
            RadiusIncrement = (float)RadiusIncrementNum.Value;
        }

        private void RemoveObject(object sender, EventArgs e)
        {
            int index = (int)RemoveSphereIndex.Value;
            if(index < 0 || index > spheres.Count -1 || spheres.Count == 0)
            {
                MessageBox.Show("Invalid index cannot remove Sphere");
                return;
            }

            spheres.RemoveAt(index);
            ObjectDetailsTexBox.AppendText("Object removed at: " + index + "\n");
        }

        private void JsonOutputTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateSphere(object sender, EventArgs e)
        {
            Sphere temp = new Sphere(SurfaceColor, Center, Velocity, EmissionColor, Radius, Transparency, Reflection, RadiusIncrement);
            spheres.Add(temp);

            ObjectDetailsTexBox.AppendText("Sphere: " + sphereCounter + " Detials\n" +
                                            "PositionXYZ: " + temp.Center.x + " : " + temp.Center.y + " : " + temp.Center.z + "\n" +
                                            "VelocityXYZ: " + temp.Velocity.x + " : " + temp.Velocity.y + " : " + temp.Velocity.z + "\n" +
                                            "SurfaceRGB: " + temp.SurfaceColor.x + " : " + temp.SurfaceColor.y + " : " + temp.SurfaceColor.z + "\n" +
                                            "EmissionColorRGB: " + temp.EmissionColor.x + " : " + temp.EmissionColor.y + " : " + temp.EmissionColor.z + "\n" +
                                            "Radius: " + temp.Radius + "\n" +
                                            "Transparency: " + temp.Transparency + "\n" +
                                            "Reflection: " + temp.Reflection + "\n" +
                                            "RadiusIncrement: " + temp.RadiusIncrement + "\n" 
                                            + "\n");
           
           sphereCounter++;
        }

        private void CreateJSON(object sender, EventArgs e)
        {
            if (spheres.Count == 0)
            {
                MessageBox.Show("Cannot create file because no spheres have been created");
                return;
            }
            string prefix = ".json";
            string fileName;
            string fileDesitination = @"..\..\..\..\RayTracerFramework\RayTracerSmall\";
            string finalPath;

            fileName = Interaction.InputBox("Name of JSON File","Create JSON file", "E.G: ObjectFile", -1, -1);
            if(fileName == "")
                return;
                
            finalPath = fileDesitination + fileName + prefix;

            /*Creating of the JSON file*/
            string JSONText;

            JSONText = "{\n" +
                        "    \"Spheres\": [\n";

            for (int i = 0; i < spheres.Count; i++)
            {
                JSONText += "    {\n";
                JSONText += "\t\"Center\": [" + " " + spheres[i].Center.x + ", " + spheres[i].Center.y + ", " + spheres[i].Center.z + " ],\n";
                JSONText += "\t\"Radius\": " + spheres[i].Radius + ",\n";
                JSONText += "\t\"Radius2\": " + spheres[i].Radius + ",\n";
                JSONText += "\t\"SurfaceColor\": [" + " " + spheres[i].SurfaceColor.x + ", " + spheres[i].SurfaceColor.y + ", " + spheres[i].SurfaceColor.z + " ],\n";
                JSONText += "\t\"EmissionColor\": [" + " " + spheres[i].EmissionColor.x + ", " + spheres[i].EmissionColor.y + ", " + spheres[i].EmissionColor.z + " ],\n";
                JSONText += "\t\"Transparency\": " + spheres[i].Transparency + ",\n";
                JSONText += "\t\"Reflection\": " + spheres[i].Reflection + ",\n";
                JSONText += "\t\"RadiusIncrement\": " + spheres[i].RadiusIncrement + ",\n";
                JSONText += "\t\"Velocity\": [" + " " + spheres[i].Velocity.x + ", " + spheres[i].Velocity.y + ", " + spheres[i].Velocity.z + " ]\n";
                if(i == spheres.Count -1)
                    JSONText += "    }\n";
                else
                    JSONText += "    },\n";
            }

            JSONText += "  ]\n";
            JSONText += "}\n";

            // string test = System.IO.File.ReadAllText(finalPath);
            JsonOutputTextBox.AppendText(JSONText);

            System.IO.File.WriteAllText(finalPath, JSONText);

            MessageBox.Show(fileName+prefix + " has been succefully created");
        }
    }
}
