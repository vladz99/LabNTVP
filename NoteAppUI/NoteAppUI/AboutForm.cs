using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ссылка на репозиторий
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GitHubLabel_LinkClicked(object sender, EventArgs e)
        {
            Process.Start("https://github.com/MazurenkoA/ContactsApp");
        }

        /// <summary>
        /// Кнопка открывает приложение для отправки письма на почту
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:vladik.zorin@yandex.ru");
        }
    }
}
