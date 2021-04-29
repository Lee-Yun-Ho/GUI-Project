using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp13
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 1번 문제 
            // Message Box를 띄우는 함수를 작성하시오!
            // Message Box에 "안녕하세요"라는 문구를 출력하시오!

            // MessageBox.Show("hellow world");


            // 2번 문제
            // Text Box로부터 숫자를 입력받아
            // Click 버튼을 누르면
            // Message Box에 해당 숫자를 출력하시오!
            // 힌트: Text Box를 생성하시오!

            //MessageBox.Show(textbox_1.Text);


            // 3번 문제
            // Text Box를 한 개 더 생성하시오!
            // 여기서도 정수를 하나 더 입력받아
            // 앞서 입력받았던 숫자와 더하시오!
            // 그리고 MessageBox에 덧셈 결과를 
            // 출력하시오!

            //string textbox1 = textbox_1.Text;

            //MessageBox.Show(textbox_1.Text + textbox_2.Text);

            // int number = int.Parse(textbox_1.Text) + int.Parse(textbox_2.Text);
             // MessageBox.Show(number.ToString());
        }
    }
}