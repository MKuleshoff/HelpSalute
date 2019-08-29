using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;
using Fptr10Lib;


namespace HelpSalute
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
         //   var psi = new ProcessStartInfo();
                       
         //   Process.Start("CMD");
            string strCmdText;
                        
            strCmdText = @"/C del /f /q %systemroot%\system32\spool\printers\*.shd \n del /f /q %systemroot%\system32\spool\printers\*.spl";
            MessageBox.Show("Через 3 минуты пробуйте распечатать");
            
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
         
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажмите и удерживайте кнопку СТОП и Кнопку ОК одновременно. Если нету у Вас кнопки ОК на принтере то есть кнопка повтарить и т.д. Держать кнопки надо одновременно пока принтер не заработает");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string strCmdText;

            strCmdText = @"/C rd /s /q %PUBLIC%\Documents\kyocera";
            MessageBox.Show("Пробуйте отсканировать");

            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string strCmdText, strcmdcommand;
          
            strCmdText = @"/C FOR /D %i in (%LOCALAPPDATA%\1C\1Cv82\????????-????-????-????-????????????) do rd /s /q %i ";
            strcmdcommand = @"/C FOR /D %i in (%APPDATA%\1C\1Cv82\????????-????-????-????-????????????) do rd /s /q %i";
            
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);
            System.Diagnostics.Process.Start("CMD.exe", strcmdcommand);
            MessageBox.Show("Пробуйте запустить 1С");
        }

        private void Button5_Click(object sender, EventArgs e)
        {

            System.Net.NetworkInformation.Ping png = new Ping();
            System.Net.NetworkInformation.PingReply pingReply = png.Send("tdupz.ru");
            if (pingReply.Status == IPStatus.Success)
               MessageBox.Show("Соединение утсановлено... Перезапустите 1С  и повторите попытку");


            else MessageBox.Show("Имеются проблемы со связью. Перезагрузите компьютер.После запуска 1с миунт через 15-20 повторите попытку. ");

           // MessageBox.Show("Перезагрузите компьютер и после запуска 1с миунт через 15-20 повторите попытку.");

        }

        private void Button6_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Позвоните Кулешову М.С. По номеру 89995707595");
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            IFptr fptr = new Fptr();
            fptr.open();
            fptr.setParam(1021, "");
            //fptr.setParam(1203, "");
            fptr.operatorLogin();
            //fptr.setParam()
           fptr.setParam(fptr.LIBFPTR_PARAM_REPORT_TYPE, fptr.LIBFPTR_RT_CLOSE_SHIFT);
            fptr.report();
            //MessageBox.Show(fptr.report());
            // fptr.checkDocumentClosed();
            fptr.close();
            fptr.destroy();
        }

        private void GroupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }
    }
}
//Добавить картинки
//После сканера рекомендуется ребут 
//Изменить порядок очистки кеша
