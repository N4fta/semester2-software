using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;



Console.Write(CryptoSquare.Ciphertext(" b  "));


public static class CryptoSquare
{
    private const string NOTALLOWED = " \n,.?!'`;:@#$%^&*()-+_=[]{}|\\/<>~";

    public static string NormalizedPlaintext(string plaintext)
    {
        return new string(plaintext.Where(c => !NOTALLOWED.Contains(c)).ToArray()).ToLower();
    }

    public static string[] PlaintextSegments(string plaintext)
    {
        int r = 0; //rows
        int c = 0; //columns
        while (r * c < plaintext.Length)
        {
            if (r < c) r++;
            else c++;
        }
        string[] textsegments;
        for (int i = 0; i < r - 1; i++)
        {
            if (i == r - 1) break;
            plaintext.Insert(c * (i + 1) + i, " ");
        }
        //plaintext = plaintext+" ";
        textsegments = plaintext.Split(" ");
        return textsegments;
    }

    public static string Encoded(string[] textsegments)
    {
        string encodedtext = "";
        int columns = textsegments[0].Length-1;
        int rows = textsegments.Length-1;
        for (int c = 0; c <= columns; c++)
        {
            for (int r = 0; r <= rows; r++)
            {
                if (r == rows)
                {
                    if (c < textsegments[r].Length)
                    {
                        try
                        {
                            encodedtext += textsegments[r][c];
                        }
                        catch
                        {
                            return c.ToString();
                        }
                        continue;
                    }
                }
                encodedtext += textsegments[r][c];
            }
            encodedtext += " ";
        }
        return encodedtext;
    }

    public static string Ciphertext(string plaintext)
    {
        string[] textsegments = PlaintextSegments(NormalizedPlaintext(plaintext));
        return Encoded(textsegments);
    }
}