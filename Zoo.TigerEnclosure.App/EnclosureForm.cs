using System;
using System.Drawing;
using System.Windows.Forms;
using Zoo.TigerEnclosure.App.Components;

namespace Zoo.TigerEnclosure.App
{
    public partial class EnclosureForm : Form
    {
        bool isAlreadyDead;

        public EnclosureForm()
        {
            isAlreadyDead = false;

            InitializeComponent();

            PictureBoxComponent.SetSize(TigerPictureBox);
            PictureBoxComponent.SetPosition(TigerPictureBox, ClientSize);

            ButtonComponent.SetSize(FeedButton);
            ButtonComponent.SetPosition(FeedButton, ClientSize);
        }

        private void EnclosureForm_Resize(object sender, EventArgs e)
        {
            PictureBoxComponent.SetPosition(TigerPictureBox, ClientSize);
            ButtonComponent.SetPosition(FeedButton, ClientSize);
        }

        private void FeedButton_Click(object sender, EventArgs e)
        {
            if (new PictureBoxComponent(TigerPictureBox).FitInside(ClientSize))
            {
                PictureBoxComponent.AdjustSize(TigerPictureBox);
                PictureBoxComponent.SetPosition(TigerPictureBox, ClientSize);
            }
            else if (!isAlreadyDead)
            {
                isAlreadyDead = true;

                FeedButton.Text = "Dead";
                FeedButton.ForeColor = Color.Red;
                FeedButton.BackColor = Color.Black;
                BackColor = Color.DarkRed;
                TigerPictureBox.Visible = false;
            }
        }
    }
}
