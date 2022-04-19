using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;




namespace Assignment_5._3
{
    public partial class Form1 : Form
    {
        string filepath;
        public Form1()
        {
            InitializeComponent();
        }

        #region Menu Buttons
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grpStudInfo.Visible = true;
            menuStart.Visible = false;
            menuSerType.Visible = true;
            menuSerType.Enabled = false;
            menuDeBin.Visible = false;
            lblBinary.Visible = false;
            lblXML.Visible = false;
            lblJSON.Visible = false;
            btnDeBin.Visible = false;
            btnDeXML.Visible = false;
            btnDeJSON.Visible = false;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text != String.Empty && txtFullName.Text != String.Empty && txtMajor.Text != String.Empty)
            {
                menuSerType.Enabled = true;
                lblSelectType.Visible = true;
            }
            else { menuSerType.Enabled = false; }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text != String.Empty && txtFullName.Text != String.Empty && txtMajor.Text != String.Empty)
            {
                menuSerType.Enabled = true;
                lblSelectType.Visible = true;
            }
            else { menuSerType.Enabled = false; }
        }

        private void txtMajor_TextChanged(object sender, EventArgs e)
        {
            if (txtID.Text != String.Empty && txtFullName.Text != String.Empty && txtMajor.Text != String.Empty)
            {
                menuSerType.Enabled = true;
                lblSelectType.Visible = true;
            }
            else { menuSerType.Enabled = false; }
        }

        private void menuSerBin_Click(object sender, EventArgs e)
        {
            lblSelectType.Visible = false;
            lblBinary.Visible = true;
            lblXML.Visible = false;
            lblJSON.Visible = false;
            btnSerBin.Visible = true;
            btnSerXML.Visible = false;
            btnSerJSON.Visible = false;
            btnDeBin.Visible = false;
            btnDeXML.Visible = false;
            btnDeJSON.Visible = false;
        }

        private void menuSerXML_Click(object sender, EventArgs e)
        {
            lblSelectType.Visible = false;
            lblBinary.Visible = false;
            lblXML.Visible = true;
            lblJSON.Visible = false;
            btnSerBin.Visible = false;
            btnSerXML.Visible = true;
            btnSerJSON.Visible = false;
            btnDeBin.Visible = false;
            btnDeXML.Visible = false;
            btnDeJSON.Visible = false;
        }

        private void menuSerJSON_Click(object sender, EventArgs e)
        {
            lblSelectType.Visible = false;
            lblBinary.Visible = false;
            lblXML.Visible = false;
            lblJSON.Visible = true;
            btnSerBin.Visible = false;
            btnSerXML.Visible = false;
            btnSerJSON.Visible = true;
            btnDeBin.Visible = false;
            btnDeXML.Visible = false;
            btnDeJSON.Visible = false;
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Binary
        private void btnSerBin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Choose a location to save the serialized file");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files(*.txt)|*.txt";
            saveFileDialog.ShowDialog();
            Stream stream = saveFileDialog.OpenFile();
            filepath = saveFileDialog.FileName;// stream pointing to file in read / write
            StreamWriter streamWriter = new StreamWriter(stream); // pointing to file in write mode
            streamWriter.WriteLine($"Student ID: {txtID.Text}"); // records into file
            streamWriter.WriteLine($"Full Name: {txtFullName.Text}");
            streamWriter.WriteLine($"Major: {txtMajor.Text}");
            streamWriter.Close();
            stream.Close();
            Student stud = new Student();
            stud.ID = Int32.Parse(txtID.Text);
            stud.FullName = txtFullName.Text;
            stud.Major = txtMajor.Text;
            FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.ReadWrite);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, stud);
            fileStream.Close();
            MessageBox.Show("Binary Serialization Successful");
            txtID.Clear();
            txtFullName.Clear();
            txtMajor.Clear();
            grpStudInfo.Visible = false;
            btnSerBin.Visible = false;
            lblBinary.Visible = false;
            menuSerType.Visible = false;
            menuStart.Visible = false;
            menuDeType.Visible = true;
            menuDeBin.Visible = true;
            menuDeBin.Enabled = true;
            menuDeXML.Visible = true;
            menuDeXML.Enabled = false;
            menuDeJSON.Visible = true;
            menuDeJSON.Enabled = false;
        }

        private void menuDeBin_Click(object sender, EventArgs e)
        {
            btnDeBin.Visible = true;
        }

        private void btnDeBin_Click(object sender, EventArgs e)
        {
            FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Student student = (Student)binaryFormatter.Deserialize(fileStream);
            StreamWriter streamWriter = new StreamWriter(filepath + "_de-serialized.txt");
            streamWriter.WriteLine($"Student ID: {student.ID}");
            streamWriter.WriteLine($"Full Name: {student.FullName}");
            streamWriter.WriteLine($"Major: {student.Major}");
            MessageBox.Show($"Decrypted File Created at {filepath}_de-serialized");
            streamWriter.Close();
            fileStream.Close();
            btnDeBin.Visible = false;
            menuStart.Visible = true;
            menuDeType.Visible = false;
        } 
        #endregion

        #region XML
        private void btnSerXML_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Choose a location to save the serialized file");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files(*.xml)|*.xml";
            saveFileDialog.ShowDialog();
            Stream stream = saveFileDialog.OpenFile();
            filepath = saveFileDialog.FileName;
            StreamWriter streamWriter = new StreamWriter(stream);
            streamWriter.WriteLine($"Student ID: {txtID.Text}");
            streamWriter.WriteLine($"Full Name: {txtFullName.Text}");
            streamWriter.WriteLine($"Major: {txtMajor.Text}");
            streamWriter.Close();
            stream.Close();
            Student stud = new Student();
            stud.ID = Int32.Parse(txtID.Text);
            stud.FullName = txtFullName.Text;
            stud.Major = txtMajor.Text;
            FileStream fileStreamxml = new FileStream(filepath, FileMode.Open, FileAccess.ReadWrite);
            SoapFormatter soapFormatter = new SoapFormatter();
            soapFormatter.Serialize(fileStreamxml, stud);
            fileStreamxml.Close();
            MessageBox.Show("XML Serialization Successful");
            txtID.Clear();
            txtFullName.Clear();
            txtMajor.Clear();
            grpStudInfo.Visible = false;
            btnSerXML.Visible = false;
            lblXML.Visible = false;
            menuSerType.Visible = false;
            menuStart.Visible = false;
            menuDeType.Visible = true;
            menuDeBin.Visible = true;
            menuDeXML.Visible = true;
            menuDeJSON.Visible = true;
            menuDeBin.Enabled = false;
            menuDeXML.Enabled = true;
            menuDeJSON.Enabled = false;
        }

        private void menuDeXML_Click(object sender, EventArgs e)
        {
            btnDeXML.Visible = true;
        }

        private void btnDeXML_Click(object sender, EventArgs e)
        {
            FileStream fileStreamxml = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            SoapFormatter soapFormatter = new SoapFormatter();
            Student student = (Student)soapFormatter.Deserialize(fileStreamxml);
            StreamWriter streamWriter = new StreamWriter(filepath + "_de-serialized.txt");
            streamWriter.WriteLine($"Student ID: {student.ID}");
            streamWriter.WriteLine($"Full Name: {student.FullName}");
            streamWriter.WriteLine($"Major: {student.Major}");
            MessageBox.Show($"Decrypted File Created at {filepath}_de-serialized");
            streamWriter.Close();
            fileStreamxml.Close();
            btnDeXML.Visible = false;
            menuStart.Visible = true;
            menuDeType.Visible = false;
        }
        #endregion

        #region JSON
        private void btnSerJSON_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Choose a location to save the serialized file");
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files(*.txt)|*.txt";
            saveFileDialog.ShowDialog();
            Stream stream = saveFileDialog.OpenFile();
            filepath = saveFileDialog.FileName;// stream pointing to file in read / write
            StreamWriter streamWriter = new StreamWriter(stream); // pointing to file in write mode
            streamWriter.WriteLine($"Student ID: {txtID.Text}"); // records into file
            streamWriter.WriteLine($"Full Name: {txtFullName.Text}");
            streamWriter.WriteLine($"Major: {txtMajor.Text}");
            streamWriter.Close();
            stream.Close();
            Student stud = new Student();
            stud.ID = Int32.Parse(txtID.Text);
            stud.FullName = txtFullName.Text;
            stud.Major = txtMajor.Text;
            FileStream fileStreamjson = new FileStream(filepath, FileMode.Open, FileAccess.ReadWrite);
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(stud.GetType());
            jsonSerializer.WriteObject(fileStreamjson, stud);
            fileStreamjson.Close();
            MessageBox.Show("JSON Serialization Successful");
            txtID.Clear();
            txtFullName.Clear();
            txtMajor.Clear();
            grpStudInfo.Visible = false;
            btnSerJSON.Visible = false;
            lblJSON.Visible = false;
            menuSerType.Visible = false;
            menuStart.Visible = false;
            menuDeType.Visible = true;
            menuDeBin.Visible = true;
            menuDeBin.Enabled = false;
            menuDeXML.Visible = true;
            menuDeXML.Enabled = false;
            menuDeJSON.Visible = true;
            menuDeJSON.Enabled = true;
        }

        private void menuDeJSON_Click(object sender, EventArgs e)
        {
            btnDeJSON.Visible = true;
        }

        private void btnDeJSON_Click(object sender, EventArgs e)
        {
            FileStream fileStreamJSON = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Student));
            Student stud = jsonSerializer.ReadObject(fileStreamJSON) as Student;
            StreamWriter streamWriter = new StreamWriter(filepath + "_de-serialized.txt");
            streamWriter.WriteLine($"Student ID: {stud.ID}");
            streamWriter.WriteLine($"Full Name: {stud.FullName}");
            streamWriter.WriteLine($"Major: {stud.Major}");
            MessageBox.Show($"Decrypted File Created at {filepath}_de-serialized");
            streamWriter.Close();
            fileStreamJSON.Close();
            btnDeJSON.Visible = false;
            menuStart.Visible = true;
            menuDeType.Visible = false;
        } 
        #endregion
    }
}
