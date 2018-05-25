//=================================================================
// Copyright (c) rocketRobin All rights reserved.
// Author 　：rocketRobin
// 创建日期　：2017/1/24 9:31:26
// 文件　 　 ：ConvertSql2Upper.Converter
// 描述　　　：
// 修改　 　 ：
//=================================================================

using System.Linq;
using System.Text;

namespace ConvertSql2Upper
{
    /// <summary>
    /// SQL关键字转换器
    /// </summary>
    public class SqlConverter : IKeywordsConvertible
    {
        public SqlConverter(string[] keywords)
        {
            Keywords = keywords;
        }
        public SqlConverter() { }

        /// <summary>
        /// 关键字集合
        /// </summary>
        public string[] Keywords
        {
            get { return keywords; }
            set
            {
                this.keywords = new string[value.Length];
                for (int i = 0; i < value.Length; i++)
                {
                    this.keywords[i] = value[i].ToLower();
                }
            }
        }

        private string[] keywords;

        /// <summary>
        /// 字符缓冲区
        /// </summary>
        private StringBuilder charBuilder = new StringBuilder();

        /// <summary>
        /// 符号缓冲区
        /// </summary>
        private StringBuilder symboBuilder = new StringBuilder();

        /// <summary>
        /// 结果缓冲区
        /// </summary>
        private StringBuilder resBuilder = new StringBuilder();

        /// <summary>
        /// 上一个字符是否是字母
        /// </summary>
        private bool lastIsLetter;

        /// <summary>
        /// 临时变量
        /// </summary>
        private string temp;

        /// <summary>
        /// 转换
        /// </summary>
        /// <param name="source">要转换的字符串</param>
        /// <returns>转换结果</returns>
        public string Convert(string source)
        {
            charBuilder.Clear();
            symboBuilder.Clear();
            resBuilder.Clear();
            lastIsLetter = true;
            temp = string.Empty;
            var isString = false;

            // 打散源字符串
            char[] charArray = source.ToArray<char>();

            // 遍历
            foreach (var c in charArray)
            {
                if (c=='\'')
                {
                    isString = !isString;
                    symboBuilder.Append(c);
                    continue;
                }


                if (isString)
                {
                    symboBuilder.Append(c);
                    continue;
                }




                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    // 如果上一个符号不是字母，就把符号缓冲区推送
                    if (!lastIsLetter)
                    {
                        PushSymbols();
                    }
                    charBuilder.Append(c);
                    lastIsLetter = true;
                }
                else
                {
                    // 如果上一个符号是字母，就把字母缓冲区推送
                    if (lastIsLetter)
                    {
                        PushLetters();
                    }
                    symboBuilder.Append(c);
                    lastIsLetter = false;
                }
            }

            // 处理最后一个缓冲区
            if (lastIsLetter)
            {
                PushLetters();
            }
            else
            {
                PushSymbols();
            }

            return resBuilder.ToString();
        }

        /// <summary>
        /// 将字符缓冲区推送至目标缓冲区
        /// </summary>
        private void PushLetters()
        {
            temp = charBuilder.ToString();
            if (Keywords.Contains(temp.ToLower()))
            {
                resBuilder.Append(temp.ToUpper());
            }
            else
            {
                resBuilder.Append(temp);
            }
            charBuilder.Clear();
        }

        /// <summary>
        /// 将符号缓冲区推送至目标缓冲区
        /// </summary>
        private void PushSymbols()
        {
            resBuilder.Append(symboBuilder.ToString());
            symboBuilder.Clear();
        }
    }
}