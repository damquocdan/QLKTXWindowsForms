using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTXWindowsForms
{
    internal class SystemQLKT
    {
        public static int StringToInt(string str)
        {
            if (int.TryParse(str, out int output))
            {
                return output;
            }

            return 0;
        }
        public static void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra nếu ký tự nhập vào không phải là số và không phải là phím điều hướng (ví dụ: phím Back)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Chặn ký tự nhập vào bằng cách xử lý sự kiện KeyPress
                e.Handled = true;
            }
        }
        public static void SendEmail(string fromEmail, string password, string toEmail, string subject, string htmlBody)
        {
            try
            {
                // Khởi tạo đối tượng SmtpClient
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromEmail, password);

                // Tạo đối tượng MailMessage
                MailMessage mailMessage = new MailMessage(fromEmail, toEmail, subject, htmlBody);
                mailMessage.IsBodyHtml = true;

                // Gửi email
                smtpClient.Send(mailMessage);
                Console.WriteLine("Email sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
            }
        }
    }
}
