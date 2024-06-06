﻿using System;
using System.Collections.Generic;
using System.Linq;

public static class ProteinTranslation
{
    public static string[] Proteins(string strand)
    {
          IDictionary<string, string> proteins = new Dictionary<string, string>();
          proteins.Add("AUG", "Methionine");
          proteins.Add("UUU", "Phenylalanine");
          proteins.Add("UUC" , "Phenylalanine");
          proteins.Add("UUA", "Leucine");
          proteins.Add("UUG" , "Leucine");
          proteins.Add("UCU", "Serine");
          proteins.Add("UCC", "Serine");
          proteins.Add("UCA", "Serine");
          proteins.Add("UCG", "Serine");
          proteins.Add("UAU", "Tyrosine");
          proteins.Add("UAC", "Tyrosine");
          proteins.Add("UGU", "Cysteine");
          proteins.Add("UGC", "Cysteine");
          proteins.Add("UGG", "Tryptophan");
          proteins.Add("UAA", "STOP");
          proteins.Add("UAG", "STOP");
          proteins.Add("UGA", "STOP");

  

        return strand
            .Select((s, i) => i)
            .Where(i => i % 3 == 0)
            .Select(i => strand.Substring(i, 3))
            .TakeWhile(s => proteins[s] != "STOP")
            .Select(s => proteins[s]).ToArray();
    }

 
}