using System;
using System.Drawing;
using System.Windows.Forms;

namespace PRAKTIKUM_GRAFIKA_KOMP{
    public partial class tugas1 : Form
{
    public tugas1()
    {
        InitializeComponent();
        this.Paint += new PaintEventHandler(tugas1_paint);
    }

    private void tugas1_paint(object sender, PaintEventArgs e)
    {
        //canvas gdi
        Graphics g = e.Graphics;

        //buat emoney
        Pen penHitam = new Pen(Color.Black, 2);
        Brush brushNavy = new SolidBrush(Color.DarkBlue);
        Brush brushGold = new SolidBrush(Color.Gold);
        Font fontCard = new Font("Montserrat", 14, FontStyle.Bold | FontStyle.Italic);
        Brush brushPutih = new SolidBrush(Color.White);

        //isi main color kartu
        g.FillRectangle(brushNavy, 50, 50, 160, 100);
        //buat garis tepi kartu
        g.DrawRectangle(penHitam, 50, 50, 160, 100);
        //buat chip emas yang biasa ada di kartu
        g.FillRectangle(brushGold, 70, 90, 25, 20);
        //tulis teks emoney
        g.DrawString("E-MONEY", fontCard, brushPutih, 110, 115);

        //buat clapperboard film
        Pen penBoldWhite = new Pen(Color.White, 3);
        Pen penGarisWhite = new Pen(Color.White, 2);
        Brush brushPapan = new SolidBrush(Color.Black);
        Font fontPapan = new Font("Consolas", 12, FontStyle.Bold);


        //pisahin sama objek sebelumnya biar ga numpuk
        int xb = 280;
        int yb = 50;

        //isi kotak papan utama (bawah)
        g.FillRectangle(brushPapan, xb, yb + 35, 220, 140);
        //gambar garis tepi
        g.DrawRectangle(penBoldWhite, xb, yb + 35, 220, 140);
        //isi kotak clapper (atas)
        g.FillRectangle(brushPapan, xb, yb, 220, 25);
        //gambar tepi
        g.DrawRectangle(penBoldWhite, xb, yb, 220, 25);
        //gambar garis miring putih 1 di clapper
        g.DrawLine(penGarisWhite, xb + 40, yb, xb + 20, yb + 25);
        //gambar garis miring putih 2 di clapper
        g.DrawLine(penGarisWhite, xb + 90, yb, xb + 70, yb + 25);
        //gambar garis miring putih 3 di clapper
        g.DrawLine(penGarisWhite, xb + 140, yb, xb + 120, yb + 25);
        //gambar garis miring putih 4 di clapper
        g.DrawLine(penGarisWhite, xb + 190, yb, xb + 170, yb + 25);

        //tulis teks di brs pertama
        g.DrawString("Prod: USHIJIMA", fontPapan, brushPutih, xb + 15, yb + 55);
        //baris kedua
        g.DrawString("Scene: 1 | Take: 1", fontPapan, brushPutih, xb + 15, yb + 95);
        //baris ketiga
        g.DrawString("Date: 09/09/2029", fontPapan, brushPutih, xb + 15, yb + 135);

        penHitam.Dispose();
        brushNavy.Dispose();
        brushGold.Dispose();
        fontCard.Dispose();
        brushPutih.Dispose();
        penBoldWhite.Dispose();
        penGarisWhite.Dispose();
        brushPapan.Dispose();
        fontPapan.Dispose();
    }
}
}