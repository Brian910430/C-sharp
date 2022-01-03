using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secretcode
{
    class theTable
    {
        public List<char> trans = new List<char>();
        public string message = "";
        public bool ch = false;
        String origin = "";

        public String Random()
        {
            origin = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            trans.Clear();
            Random ran = new Random();
            for (int i = 0; i < 52; i++)
            {
                int index = ran.Next( 52 - i);
                trans.Add(origin[index]);
                origin = origin.Remove(index, 1);
            }
            String ans = new String(trans.ToArray());
            return ans;
        }

        public string Confirm(string input)
        {
            ch = false;
            if (input.Length != 52) return "轉換表不合法";

            for (int i = 0; i < input.Length; i++)
            {
                if ((int)input[i] < 65 || (int)input[i] > 90 && (int)input[i] < 97 || (int)input[i] > 122)
                    return "轉換表不合法";
            }

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++) 
                {
                    if(input[i] == input[j])
                        return "轉換表不合法";
                }
            }

            trans.Clear();
            for (int i = 0; i < input.Length; i++)
            {
                trans.Add(input[i]);
            }

            ch = true;
            message = "新的轉換表\r\n" + input + "\r\n\r\n";
            return "合法轉換表";
        }

        public string Encrypt(string input)
        {
            origin = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if ((int)input[i] < 65 || (int)input[i] > 90 && (int)input[i] < 97 || (int)input[i] > 122)
                    output += input[i];
                else
                {
                    int index = origin.IndexOf(input[i]);
                    output += trans[index];
                }
            }

            message = "加密\r\n明文：" + input + "\r\n密文：" + output + "\r\n\r\n";
            return output;
        }

        public string Decrypt(string input)
        {
            origin = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if ((int)input[i] < 65 || (int)input[i] > 90 && (int)input[i] < 97 || (int)input[i] > 122)
                    output += input[i];
                else
                {
                    int index = trans.IndexOf(input[i]);
                    output += origin[index];
                }
            }

            message = "解密\r\n密文：" + input + "\r\n明文：" + output + "\r\n\r\n";
            return output;
        }
    }
}
