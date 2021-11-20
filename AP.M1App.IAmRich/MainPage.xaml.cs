using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace AP.M1App.IAmRich;

public partial class MainPage : ContentPage
{
    bool rich = false;

    public MainPage()
    {
        InitializeComponent();
    }

    void OnRichStateClicked(object sender, EventArgs e)
    {
        if (rich)
        {
            RichState.Text = $"You are: poor";
            rich = false;
            RichStateButton.Text = "Click to get rich!";


        }
        else
        {
            RichState.Text = $"You are: rich";
            rich = true;
            RichStateButton.Text = "Click to be poor again!";
        }

        SemanticScreenReader.Announce(RichState.Text);
    }
}

