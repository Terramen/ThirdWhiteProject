using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

public static class VanDown
{
    public static string Check(string j)
    {
        var p = @"https?://.*?(?=<)";
        
        var k = new Regex(p);

        var g = k.Match(j);

        if (g.Success)
        {
            return g.Value;
        }
        
        return string.Empty;
    }
}
