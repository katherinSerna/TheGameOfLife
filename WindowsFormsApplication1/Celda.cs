﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Celda
    {
        public enum Estado { viva, muerta };

        int x, y;
        public Estado estado_actual;
        public Estado estado_siguiente;
        static int lado = 20;

        public Celda(int x, int y, Random r)
        {

            double d = r.NextDouble();
            if (d < .80)
                estado_actual = Estado.muerta;
            else
                estado_actual = Estado.viva;

            this.x = x; this.y = y;
        }
        public void Dibuja(Form f)
        {

            Graphics g = f.CreateGraphics();
            g.DrawRectangle(new Pen(Color.Black, 1), x, y, lado, lado);
            if (estado_actual == Estado.viva)
                g.FillRectangle(new SolidBrush(Color.Black), x, y, lado, lado);


        }
        public void update()
        {
            estado_actual = estado_siguiente;
        }
    }

    class Tablero
    {
        List<List<Celda>> tablero;
        int tamaño;
        Random r = new Random();
        public Tablero(int tamaño)
        {
            tablero = new List<List<Celda>>();
            this.tamaño = tamaño;
            for (int i = 0; i < tamaño; i++)
            {
                List<Celda> temp = new List<Celda>();
                for (int j = 0; j < tamaño; j++)
                {
                    temp.Add(new Celda(20 + i * 20, 20 + j * 20, r));
                }
                tablero.Add(temp);

            }

        }

        public void Dibuja(Form f)
        {

            for (int i = 0; i < tamaño; i++)
                for (int j = 0; j < tamaño; j++)
                {
                    tablero[i][j].Dibuja(f);
                }
        }

        public void next()
        {
            for (int i = 0; i < tamaño; i++)
                for (int j = 0; j < tamaño; j++)
                {
                    int vecinas = cuantas_vacinas_vivas(i, j);
                    // Any live cell with fewer than two live neighbours dies, as if caused by under-population.
                    if (vecinas < 2)
                        tablero[i][j].estado_siguiente = Celda.Estado.muerta;
                    //Any live cell
                    if (tablero[i][j].estado_actual == Celda.Estado.viva)
                    {
                        // with two or three live neighbours lives on to the next generation.
                        if (vecinas == 2 || vecinas == 3)
                        {

                        }
                        // with more than three live neighbours dies 
                        else if (vecinas > 3)
                        {
                            tablero[i][j].estado_siguiente = Celda.Estado.muerta;
                        }

                    }
                    //Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.
                    else
                    {
                        if (vecinas == 3)
                        {
                            tablero[i][j].estado_siguiente = Celda.Estado.viva;

                        }
                    }

                }

        }

        public void update()
        {
            for (int i = 0; i < tamaño; i++)
                for (int j = 0; j < tamaño; j++)
                    tablero[i][j].update();
        }


        int cuantas_vacinas_vivas(int i, int j)
        {
            int vivas = 0;
            //NorOeste
            if (i > 0 && j > 0 && tablero[i - 1][j - 1].estado_actual == Celda.Estado.viva)
                vivas++;
            //Norte
            if (i > 0 && tablero[i - 1][j].estado_actual == Celda.Estado.viva)
                vivas++;
            //NorEste
            if (i > 0 && j < tamaño - 1 && tablero[i - 1][j + 1].estado_actual == Celda.Estado.viva)
                vivas++;
            //Oeste
            if (j > 0 && tablero[i][j - 1].estado_actual == Celda.Estado.viva)
                vivas++;
            //Este
            if (j < tamaño - 1 && tablero[i][j + 1].estado_actual == Celda.Estado.viva)
                vivas++;
            //SurOeste
            if (i < tamaño - 1 && j > 0 && tablero[i + 1][j - 1].estado_actual == Celda.Estado.viva)
                vivas++;
            //Sur
            if (i < tamaño - 1 && tablero[i + 1][j].estado_actual == Celda.Estado.viva)
                vivas++;
            //SurEste
            if (i < tamaño - 1 && j < tamaño - 1 && tablero[i + 1][j + 1].estado_actual == Celda.Estado.viva)
                vivas++;

            return vivas;

        }


    }
}
