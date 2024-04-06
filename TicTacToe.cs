using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class TicTacToe : MonoBehaviour
{
    Boolean checker;
    int plusone;
    public Text bntText1 = null;
    public Text bntText2 = null;
    public Text bntText3 = null;
    public Text bntText4 = null;
    public Text bntText5 = null;
    public Text bntText6 = null;
    public Text bntText7 = null;
    public Text bntText8 = null;
    public Text bntText9 = null;

    public Text bntResestGame = null;
    public Text bntNewGame = null;
    public Text msgFeedback = null;

    public Text txtPlayerX;
    public Text txtPlayerO;

    public void score()
    {
        if(bntText1.text=="X"&& bntText2.text =="X"&& bntText3.text=="X")
        {
            bntText1.color = Color.red;
            bntText2.color = Color.red;
            bntText3.color = Color.red;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }

        if (bntText1.text == "X" && bntText4.text == "X" && bntText7.text == "X")
        {
            bntText1.color = Color.blue;
            bntText4.color = Color.blue;
            bntText7.color = Color.blue;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }

        if (bntText1.text == "X" && bntText5.text == "X" && bntText9.text == "X")
        {
            bntText1.color = Color.red;
            bntText5.color = Color.red;
            bntText9.color = Color.red;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }

        if (bntText3.text == "X" && bntText5.text == "X" && bntText7.text == "X")
        {
            bntText3.color = Color.green;
            bntText5.color = Color.green;
            bntText7.color = Color.green;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }

        if (bntText3.text == "X" && bntText5.text == "X" && bntText7.text == "X")
        {
            bntText1.color = Color.gray;
            bntText2.color = Color.gray;
            bntText3.color = Color.gray;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }

        if (bntText2.text == "X" && bntText5.text == "X" && bntText8.text == "X")
        {
            bntText1.color = Color.yellow;
            bntText4.color = Color.yellow;
            bntText7.color = Color.yellow;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }

        if (bntText3.text == "X" && bntText6.text == "X" && bntText9.text == "X")
        {
            bntText1.color = Color.cyan;
            bntText2.color = Color.cyan;
            bntText3.color = Color.cyan;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }

        if (bntText4.text == "X" && bntText5.text == "X" && bntText6.text == "X")
        {
            bntText1.color = Color.green;
            bntText4.color = Color.green;
            bntText7.color = Color.green;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }

        if (bntText7.text == "X" && bntText8.text == "X" && bntText9.text == "X")
        {
            bntText1.color = Color.blue;
            bntText4.color = Color.blue;
            bntText7.color = Color.blue;
            msgFeedback.text = "The Winner is Player X";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        //============================player o===================================
        if (bntText1.text == "O" && bntText2.text == "O" && bntText3.text == "O")
        {
            bntText1.color = Color.red;
            bntText2.color = Color.red;
            bntText3.color = Color.red;
            msgFeedback.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        if (bntText1.text == "O" && bntText4.text == "O" && bntText7.text == "O")
        {
            bntText1.color = Color.blue;
            bntText4.color = Color.blue;
            bntText7.color = Color.blue;
            msgFeedback.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        if (bntText1.text == "O" && bntText5.text == "O" && bntText9.text == "O")
        {
            bntText1.color = Color.red;
            bntText5.color = Color.red;
            bntText9.color = Color.red;
            msgFeedback.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        if (bntText3.text == "O" && bntText5.text == "O" && bntText7.text == "O")
        {
            bntText3.color = Color.green;
            bntText5.color = Color.green;
            bntText7.color = Color.green;
            msgFeedback.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        if (bntText3.text == "O" && bntText5.text == "O" && bntText7.text == "O")
        {
            bntText1.color = Color.gray;
            bntText2.color = Color.gray;
            bntText3.color = Color.gray;
            msgFeedback.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        if (bntText2.text == "O" && bntText5.text == "O" && bntText8.text == "O")
        {
            bntText1.color = Color.yellow;
            bntText4.color = Color.yellow;
            bntText7.color = Color.yellow;
            msgFeedback.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        if (bntText3.text == "O" && bntText6.text == "O" && bntText9.text == "O")
        {
            bntText1.color = Color.cyan;
            bntText2.color = Color.cyan;
            bntText3.color = Color.cyan;
            msgFeedback.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        if (bntText4.text == "O" && bntText5.text == "O" && bntText6.text == "O")
        {
            bntText1.color = Color.green;
            bntText4.color = Color.green;
            bntText7.color = Color.green;
            msgFeedback.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }

        if (bntText7.text == "O" && bntText8.text == "O" && bntText9.text == "O")
        {
            bntText1.color = Color.blue;
            bntText4.color = Color.blue;
            bntText7.color = Color.blue;
            msgFeedback.text = "The Winner is Player O";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
    }
    public void bntText1_Click()
    {
        if(checker == false)
        {
            bntText1.text = "X";
            checker = true;
        }
        else
        {
            
                bntText1.text = "O";
                checker = false;
            
        }
        score();
    }

    public void bntText2_Click()
    {
        if (checker == false)
        {
            bntText2.text = "X";
            checker = true;
        }
        else
        {
            
                bntText2.text = "O";
                checker = false;
            
        }
        score();
    }
    public void bntText3_Click()
    {
        if (checker == false)
        {
            bntText3.text = "X";
            checker = true;
        }
        else
        {
            
                bntText3.text = "O";
                checker = false;
            
        }
        score();
    }
    public void bntText4_Click()
    {
        if (checker == false)
        {
            bntText4.text = "X";
            checker = true;
        }
        else
        {
            
                bntText4.text = "O";
                checker = false;
            
        }
        score();
    }
    public void bntText5_Click()
    {
        if (checker == false)
        {
            bntText5.text = "X";
            checker = true;
        }
        else
        {
            
                bntText5.text = "O";
                checker = false;
            
        }
        score();
    }
    public void bntText6_Click()
    {
        if (checker == false)
        {
            bntText6.text = "X";
            checker = true;
        }
        else
        {
            
                bntText6.text = "O";
                checker = false;
            
        }
        score();
    }
    public void bntText7_Click()
    {
        if (checker == false)
        {
            bntText7.text = "X";
            checker = true;
        }
        else
        {
            
                bntText7.text = "O";
                checker = false;
            
        }
        score();
    }
    public void bntText8_Click()
    {
        if (checker == false)
        {
            bntText8.text = "X";
            checker = true;
        }
        else
        {
            
                bntText8.text = "O";
                checker = false;
            
        }
        score();
    }
    public void bntText9_Click()
    {
        if (checker == false)
        {
            bntText9.text = "X";
            checker = true;
        }
        else
        {
                bntText9.text = "O";
                checker = false;
        }
        score();
    }
    public void bntResestGame_Click()
    {
        bntText1.text = "";
        bntText2.text = "";
        bntText3.text = "";
        bntText4.text = "";
        bntText5.text = "";
        bntText6.text = "";
        bntText7.text = "";
        bntText8.text = "";
        bntText9.text = "";

        bntText1.color = Color.black;
        bntText2.color = Color.black;
        bntText3.color = Color.black;
        bntText4.color = Color.black;
        bntText5.color = Color.black;
        bntText6.color = Color.black;
        bntText7.color = Color.black;
        bntText8.color = Color.black;
        bntText9.color = Color.black;
    }
    public void bntNewGame_Click()
    {
        bntResestGame_Click();
        txtPlayerX.text = "";
        txtPlayerO.text = "";

    }
}
