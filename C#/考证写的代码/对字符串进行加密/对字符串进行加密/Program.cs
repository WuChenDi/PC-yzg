﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 对字符串进行加密
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string s_text, s_key, s_result;
            s_result = "";
            char ch;
            Console.WriteLine("请输入原字符串:");
            s_text = Console.ReadLine();
            Console.WriteLine("请输入密钥字符串:");
            s_key = Console.ReadLine();
            if (s_text.Length != s_key.Length)
            {
                Console.WriteLine("密钥字符串与原字符串的长度必须相等");
                return;
            }
            for (i = 0; i < s_text.Length; i++)
            {
                ch = s_text[i];
                ch ^= s_key[i];
                s_result += ch;
            }
            Console.WriteLine("加密后的字符串位");
            Console.WriteLine(s_result);
        }
    }
}
