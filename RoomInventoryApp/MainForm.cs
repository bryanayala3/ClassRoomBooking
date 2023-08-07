using System.Text.RegularExpressions;

namespace RoomInventoryApp
{

    /*
     * Final Exam
     * April 18, 2023
     * Programming Concepts 2
     * Bryan Ayala
     */

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //General Variables:
        int recordID = 0;
        int fileCount = 0;
        string newPath;
        string name;
        DateTime startDate;
        string roomNumber;
        int capacity;
        int projectors;
        bool smartBoard;
        bool accessible;

        IClassroomManager methodsManager = new IClassroomManager();
        Classroom methodsClassroom = new Classroom();

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblMessages.Text = "";
            newPath = "C:\\BryanAyala\\notesAssignmentBryanA";
            if (!Directory.Exists(newPath))
            {
                Directory.CreateDirectory(newPath);
            }

            lblMessages.ForeColor = Color.Red;
            lblMessages.Text = "";
            txtRoomId.Enabled = false;

            txtRoomId.Text = methodsManager.GetRecordID(newPath).ToString();
        }

        private void btnSaveRoom_Click(object sender, EventArgs e)
        {
            lblMessages.ForeColor = Color.Red;
            lblMessages.Text = "";
            listBoxRooms.Items.Clear();

            if (txtRoomNumber.Text != "")
            {
                roomNumber = txtRoomNumber.Text;
                roomNumber = roomNumber.Trim();
                roomNumber = roomNumber.ToUpper();

                if (!methodsClassroom.CheckRoomNumber(roomNumber))
                {
                    lblMessages.Text = lblMessages.Text + "Please Enter the Room Number\n";
                }

            }
            else
            {
                lblMessages.Text = lblMessages.Text + "Please Enter the Room Number\n";
            }

            if (txtCapacity.Text != "")
            {
                try
                {
                    capacity = Int32.Parse(txtCapacity.Text.Trim());
                    if (capacity < 0)
                    {
                        throw new Exception();

                    }
                }
                catch (Exception)
                {
                    lblMessages.Text = lblMessages.Text + "Please Enter an integer positive Capacity\n";
                }

            }
            else
            {
                lblMessages.Text = lblMessages.Text + "Please Enter the Capacity\n";
            }

            if (txtProjectors.Text != "")
            {
                try
                {
                    projectors = Int32.Parse(txtProjectors.Text.Trim());
                    if (projectors < 0)
                    {
                        throw new Exception();

                    }
                }
                catch (Exception)
                {
                    lblMessages.Text = lblMessages.Text + "Please Enter an integer positive number of Projectors\n";
                }


            }
            else
            {
                projectors = 0;
            }

            if (hasSmartBoardCheckBox.Checked)
            {
                smartBoard = true;
            }
            else
            {
                smartBoard = false;
            }

            if (isAccessibleCheckBox.Checked)
            {
                accessible = true;
            }
            else
            {
                accessible = false;
            }

            if (lblMessages.Text == "")
            {

                recordID = Int32.Parse(txtRoomId.Text);


                if (!methodsManager.IsBookLoan(recordID))
                {

                    Classroom myRecord = new Classroom(recordID, roomNumber, capacity, projectors, smartBoard, accessible);

                    methodsManager.CreateNewFile(myRecord, newPath);


                    lblMessages.ForeColor = Color.Blue;
                    lblMessages.Text = methodsManager.AddClassroom(myRecord);


                }
                else
                {
                    lblMessages.Text = lblMessages.Text + "The Record already exist\n";
                }
            }
        }

        private void btnResetForNext_Click(object sender, EventArgs e)
        {
            txtRoomId.Text = methodsManager.GetRecordID(newPath).ToString();
            txtRoomNumber.Clear();
            txtCapacity.Clear();
            txtProjectors.Clear();
            hasSmartBoardCheckBox.Checked = false;
            isAccessibleCheckBox.Checked = false;
            lblMessages.Text = "";
            listBoxRooms.Items.Clear();
            radioBtnM.Checked = false;
            radioBtnN.Checked = false;
            radioBtnY.Checked = false;
            txtMinCapacity.Clear();
            txtRoomNumber.Enabled = true;
        }

        private void btnShowRooms_Click(object sender, EventArgs e)
        {
            listBoxRooms.Items.Clear();
            lblMessages.Text = "";
            lblMessages.ForeColor = Color.Red;
            int minCapacity = 0;
            bool btnN = false;
            bool btnY = false;
            bool btnM = false;
            List<string> myElements = new List<string>();


            if (Directory.GetFiles(newPath).Length > 0)
            {
                if (txtMinCapacity.Text.Length > 0)
                {
                    try
                    {
                        minCapacity = Int32.Parse(txtMinCapacity.Text);
                        if (minCapacity < 0)
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception ex)
                    {
                        lblMessages.Text = "Please Enter a integer positive number as Capacity";
                    }
                }
                else { minCapacity = 0; }
                if (lblMessages.Text == "")
                {
                    if (radioBtnM.Checked)
                    {
                        btnM = true;
                    }
                    else if (radioBtnN.Checked)
                    {
                        btnN = true;
                    }
                    else if (radioBtnY.Checked)
                    {
                        btnY = true;
                    }

                    myElements = methodsManager.GetFiles(newPath, btnM, btnN, btnY, minCapacity);

                    foreach (string myElement in myElements)
                    {
                        listBoxRooms.Items.Add(myElement);

                    }
                }
            }
            else { lblMessages.Text = "Any record was saved"; }

        }

        private void listBoxRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMessages.Text = "";
            if (listBoxRooms.SelectedIndex != -1)
            {
                string itemFile = listBoxRooms.SelectedItem.ToString();

                string[] myInfo = methodsManager.GetRoomInfo(itemFile, newPath);

                txtRoomId.Text = myInfo[0];
                txtRoomNumber.Text = myInfo[1];
                txtCapacity.Text = myInfo[2];
                txtProjectors.Text = myInfo[3];
                if (myInfo[4] == "yes")
                {
                    hasSmartBoardCheckBox.Checked = true;
                }
                else
                {
                    hasSmartBoardCheckBox.Checked = false;
                }
                if (myInfo[5] == "yes")
                {
                    isAccessibleCheckBox.Checked = true;
                }
                else
                {
                    isAccessibleCheckBox.Checked = false;
                }

                txtRoomNumber.Enabled = false;
            }

        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            lblMessages.Text = "";
            lblMessages.ForeColor = Color.Red;


            if (txtRoomNumber.Text != "")
            {
                roomNumber = txtRoomNumber.Text;
                roomNumber = roomNumber.Trim();
                roomNumber = roomNumber.ToUpper();

                if (!methodsClassroom.CheckRoomNumber(roomNumber))
                {
                    lblMessages.Text = lblMessages.Text + "Please Enter the Room Number\n";
                }

            }
            else
            {
                lblMessages.Text = lblMessages.Text + "Please Enter the Room Number\n";
            }

            if (txtCapacity.Text != "")
            {
                try
                {
                    capacity = Int32.Parse(txtCapacity.Text.Trim());
                    if (capacity < 0)
                    {
                        throw new Exception();

                    }
                }
                catch (Exception)
                {
                    lblMessages.Text = lblMessages.Text + "Please Enter an integer positive Capacity\n";
                }


            }
            else
            {
                lblMessages.Text = lblMessages.Text + "Please Enter the Capacity\n";
            }

            if (txtProjectors.Text != "")
            {
                try
                {
                    projectors = Int32.Parse(txtProjectors.Text.Trim());
                    if (projectors < 0)
                    {
                        throw new Exception();

                    }
                }
                catch (Exception)
                {
                    lblMessages.Text = lblMessages.Text + "Please Enter an integer positive number of Projectors\n";
                }


            }
            else
            {
                projectors = 0;
            }

            if (hasSmartBoardCheckBox.Checked)
            {
                smartBoard = true;
            }
            else
            {
                smartBoard = false;
            }

            if (isAccessibleCheckBox.Checked)
            {
                accessible = true;
            }
            else
            {
                accessible = false;
            }

            if (lblMessages.Text == "")
            {

                recordID = Int32.Parse(txtRoomId.Text);


                
                

                    Classroom myRecord = new Classroom(recordID, roomNumber, capacity, projectors, smartBoard, accessible);

                    methodsManager.CreateNewFile(myRecord, newPath);


                    lblMessages.ForeColor = Color.Blue;
                    lblMessages.Text = methodsManager.EditClassroom(newPath, myRecord);
                    listBoxRooms.Items.Clear();


                
                
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}