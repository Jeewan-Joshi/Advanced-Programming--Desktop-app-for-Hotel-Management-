using System.Collections;
namespace Hotel_Management_
{
    public partial class Form1 : Form
    {
        private readonly ArrayList rooms =new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string number = txtRN.Text.Trim();
            string type = txtRT.Text.Trim();

            if (number == "" || type == "")
            {
                MessageBox.Show("Enter a room number and room type.");
                return;
            }

            if (!decimal.TryParse(txtNR.Text.Trim(), out decimal rate) || rate <= 0)
            {
                MessageBox.Show("Enter a nightly rate greater than zero.");
                return;
            }

            foreach (Room existing in rooms)
            {
                if (existing.RoomNumber == number)
                {
                    MessageBox.Show("That room number already exists.");
                    return;
                }
            }

            Room room = new Room(number, type, rate);
            rooms.Add(room);
            dgvRooms.Rows.Add(room.RoomNumber, room.RoomType,
                              room.NightlyRate, room.Status);

            txtRN.Clear();
            txtRT.Clear();
            txtNR.Clear();
        }
    }
}
