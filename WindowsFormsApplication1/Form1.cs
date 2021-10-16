using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<string> errorList = new List<string>();

        private void AddValueButton_Click(object sender, EventArgs e)
        {
           coordinatesListBox.Items.Add(inputTextBox.Text);
           inputTextBox.Clear();           
        }

        private void DeleteValueButton_Click(object sender, EventArgs e)
        {
            if (coordinatesListBox.SelectedIndex != -1)
            {
                if (coordinatesListBox.SelectedIndex == 0)
                {
                    MessageBox.Show("Sağ üst koordinatları belirten ilk satır silinemez.Temizle işlemi yapabilirsiniz.");
                }
                else
                {
                    coordinatesListBox.Items.RemoveAt(coordinatesListBox.SelectedIndex);
                }               
            }
            else 
            {
                MessageBox.Show("Silinecek değeri seçiniz.");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            coordinatesListBox.Items.Clear();
        }

        private void NavigateButton_Click(object sender, EventArgs e)
        {
            if (coordinatesListBox.Items.Count > 0)
            {
                string[] navArray = new string[coordinatesListBox.Items.Count];

                for (int i = 0; i < coordinatesListBox.Items.Count; i++)
                {
                    navArray[i] = coordinatesListBox.Items[i].ToString();
                }

                errorList.Clear();

                List<string> resultArray = CalculatePosition(navArray);

                if (errorList.Count > 0)
                {
                    MessageBox.Show(resultArray[0]);
                }
                else
                { 
                    for (int i = 0; i < resultArray.Count; i++)
			        {
                        outputListBox.Items.Add(resultArray[i]);
			        }                   
                }               
            }
           
        }

        public List<string> CalculatePosition(string[] valArrayList) 
        {
            List<string> resultList = new List<string>();

            if (valArrayList.Count() > 1)
            {

                string[] uperRightCoord = valArrayList[0].ToString().Split(' ').ToArray();
                if (uperRightCoord.Count() == 2)
                {
                    bool isDigit = true;
                    for (int i = 0; i < uperRightCoord.Count(); i++)
                    {

                        if (!char.IsDigit(uperRightCoord[i].ToString(), 0))
                        {
                            isDigit = false;
                        }
                    }
                    if (isDigit)
                    {
                        string[] roversCoordinates = valArrayList.Skip(1).ToArray();

                        bool isEvenNumber = roversCoordinates.Count() % 2 == 0 ? true : false;
                        if (isEvenNumber)
                        {
                            List<string> firstValueList = new List<string>();
                            for (int i = 0; i < roversCoordinates.Count(); i = i + 2)
                            {
                                firstValueList.Add(roversCoordinates[i]);
                            }

                            List<string> secondValueList = new List<string>();
                            for (int j = 1; j < roversCoordinates.Count(); j = j + 2)
                            {
                                secondValueList.Add(roversCoordinates[j]);

                            }

                            int riversCount = Convert.ToInt32((roversCoordinates.Count() / 2));
                            for (int k = 0; k < riversCount; k++)
                            {
                                string[] riverPositionArray = firstValueList[k].Split(' ').ToArray();
                                char[] riverInstructionsArray = secondValueList[k].ToArray();

                                if (!char.IsDigit(riverPositionArray[0].ToString(), 0) || !char.IsDigit(riverPositionArray[1].ToString(), 0))
                                {
                                    errorList.Add("Konumun ilk iki değeri, sayısal değer olmalı.Hatalı değer: " + riverPositionArray[0].ToString() + riverPositionArray[1].ToString());
                                }
                                else
                                {
                                    int xCoord = Convert.ToInt32(riverPositionArray[0]);
                                    int yCoord = Convert.ToInt32(riverPositionArray[1]);
                                    string direction = riverPositionArray[2];

                                    for (int l = 0; l < riverInstructionsArray.Count(); l++)
                                    {
                                        if (riverInstructionsArray[l].ToString() == "M")
                                        {
                                            if (direction == "N")
                                            {
                                                yCoord = yCoord + 1;
                                            }
                                            else if (direction == "S")
                                            {
                                                yCoord = yCoord - 1;
                                            }
                                            else if (direction == "W")
                                            {
                                                xCoord = xCoord - 1;
                                            }
                                            else if (direction == "E")
                                            {
                                                xCoord = xCoord + 1;
                                            }
                                            else
                                            {
                                                errorList.Add("Gezici yönü N,S,W ve E harflerinden biri olmalıdır.Hatalı değer : " + direction);
                                            }

                                        }
                                        else if (riverInstructionsArray[l].ToString() == "L")
                                        {
                                            if (direction == "N")
                                            {
                                                direction = "W";
                                            }
                                            else if (direction == "S")
                                            {
                                                direction = "E";
                                            }
                                            else if (direction == "W")
                                            {
                                                direction = "S";
                                            }
                                            else if (direction == "E")
                                            {
                                                direction = "N";
                                            }
                                            else
                                            {
                                                errorList.Add("Gezici yönü N,S,W ve E harflerinden biri olmalıdır.Hatalı değer : " + direction);
                                            }
                                        }
                                        else if (riverInstructionsArray[l].ToString() == "R")
                                        {
                                            if (direction == "N")
                                            {
                                                direction = "E";
                                            }
                                            else if (direction == "S")
                                            {
                                                direction = "W";
                                            }
                                            else if (direction == "W")
                                            {
                                                direction = "N";
                                            }
                                            else if (direction == "E")
                                            {
                                                direction = "S";
                                            }
                                            else
                                            {
                                                errorList.Add("Gezici yönü N,S,W ve E harflerinden biri olmalıdır.Hatalı değer : " + direction);
                                            }
                                        }
                                        else
                                        {
                                            errorList.Add("Talimatlar sadece L,R ve M harflerinden oluşmalıdır.Hatalı değer :" + riverInstructionsArray[l].ToString());
                                        }
                                    }

                                    resultList.Add(xCoord.ToString() + " " + yCoord.ToString() + " " + direction);

                                }
                            }
                        }
                        else
                        {
                            errorList.Add("Gezici konum ve talimat sayıları eşit olmalıdır.");
                        }


                    }
                    else
                    {
                        errorList.Add("Platonun sağ üst koordinatları için sayısal değer giriniz.");
                    }
                }
                else
                {
                    errorList.Add("Sağ üst koordinatlar için arada boşluk olacak şekilde 2 sayısal değer giriniz.");
                }


            }
            else
            {
                errorList.Add("Listeye sağ üst koordinat ve en az bir tane gezici bilgisi giriniz.");
            }

            if (errorList.Count > 0)
            {
                resultList = errorList;
            }
            
            return resultList;
        }
    }
}
