using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Settings
{
    public static string kolay = "kolay";
    public static string orta = "orta";
    public static string zor = "zor";

    public static string kolayPuan = "kolayPuan";
    public static string ortaPuan = "ortaPuan";
    public static string zorPuan = "zorPuan";

    public static string kolayMama= "kolayMama";
    public static string ortaMama = "ortaMama";
    public static string zorMama = "zorMama";

    public static string muzikAcik = "muzikAcik";
    public static void KolayDegerAta(int kolay)
    {
        PlayerPrefs.SetInt(Settings.kolay, kolay);
    }
    public static int KolayDegerOku()
    {
        return PlayerPrefs.GetInt(Settings.kolay);
    }
    public static void OrtaDegerAta(int orta)
    {
        PlayerPrefs.SetInt(Settings.orta, orta);
    }
    public static int OrtaDegerOku()
    {
        return PlayerPrefs.GetInt(Settings.orta);
    }
    public static void ZorDegerAta(int zor)
    {
        PlayerPrefs.SetInt(Settings.zor, zor);
    }
    public static int ZorDegerOku()
    {
        return PlayerPrefs.GetInt(Settings.zor);
    }


    public static void KolayPuanDegerAta(int kolayPuan)
    {
        PlayerPrefs.SetInt(Settings.kolayPuan, kolayPuan);
    }
    public static int KolayPuanDegerOku()
    {
        return PlayerPrefs.GetInt(Settings.kolayPuan);
    }
    public static void OrtaPuanDegerAta(int ortaPuan)
    {
        PlayerPrefs.SetInt(Settings.ortaPuan, ortaPuan);
    }
    public static int OrtaPuanDegerOku()
    {
        return PlayerPrefs.GetInt(Settings.ortaPuan);
    }
    public static void ZorPuanDegerAta(int zorPuan)
    {
        PlayerPrefs.SetInt(Settings.zorPuan, zorPuan);
    }
    public static int ZorPuanDegerOku()
    {
        return PlayerPrefs.GetInt(Settings.zorPuan);
    }


    public static void KolayMamaDegerAta(int kolayMama)
    {
        PlayerPrefs.SetInt(Settings.kolayMama, kolayMama);
    }
    public static int KolayMamaDegerOku()
    {
        return PlayerPrefs.GetInt(Settings.kolayMama);
    }
    public static void OrtaMamaDegerAta(int ortaMama)
    {
        PlayerPrefs.SetInt(Settings.ortaMama, ortaMama);
    }
    public static int OrtaMamaDegerOku()
    {
        return PlayerPrefs.GetInt(Settings.ortaMama);
    }
    public static void ZorMamaDegerAta(int zorMama)
    {
        PlayerPrefs.SetInt(Settings.zorMama, zorMama);
    }
    public static int ZorMamaDegerOku()
    {
        return PlayerPrefs.GetInt(Settings.zorMama);
    }
    public static void MuzikAcikDegerAta(int muzikAcik)
    {
        PlayerPrefs.SetInt(Settings.muzikAcik, muzikAcik);
    }
    
    public static int MuzikAcikDegerOku()
    {
        return PlayerPrefs.GetInt(Settings.muzikAcik);
        
    }

    public static bool KayitVarmi()
    {
        if (PlayerPrefs.HasKey(Settings.kolay) || PlayerPrefs.HasKey(Settings.orta) || PlayerPrefs.HasKey(Settings.zor))
        {
            return true;
        }
        else { return false; }
    }
    public static bool MuzikVarmi()
    {
        if (PlayerPrefs.HasKey(Settings.muzikAcik))
        {
            return true;
        }
        else { return false; }
    }
}
