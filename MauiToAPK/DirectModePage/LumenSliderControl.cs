﻿
namespace MauiToAPK;

public partial class DirectModePage : ContentPage
{
    public void SlidersLumenThreadsInit()
    {
        sliderControl_5 = new(ControlSliderLumen_5);
        sliderControl_5.Start();

        sliderControl_6 = new(ControlSliderLumen_6);
        sliderControl_6.Start();
    }


    bool LumenSliderEnable_5 = false;
    private Thread sliderControl_5;
    private void lum5_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        LumenSliderEnable_5 = true;
    }
    private void ControlSliderLumen_5()
    {
        while (true)
        {
            if (LumenSliderEnable_5)
            {
                RunLumen(1, Convert.ToInt32(Math.Round(lum5.Value)));
                LumenSliderEnable_5 = false;
                Thread.Sleep(SLIDER_DELAY);
            }
        }
    }



    bool lumenSliderEnable_6 = false;
    private Thread sliderControl_6;
    private void lum6_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        lumenSliderEnable_6 = true;
    }
    private void ControlSliderLumen_6()
    {
        while (true)
        {
            if (lumenSliderEnable_6)
            {
                RunLumen(2, Convert.ToInt32(Math.Round(lum6.Value)));
                lumenSliderEnable_6 = false;
                Thread.Sleep(SLIDER_DELAY);
            }
        }
    }
}