string[] ConcatArrayString(string strValue, string cutSym)
{
    return strValue.Split(cutSym).Where(item => item.Length > 0).ToArray();
}

string[] arrStr = new string[] { "hello", "2", "world", ":-)", "word" };
int sizeWord = 3;
string strArr = String.Empty;
string cutChars = "\n";

for (int i = 0; i < arrStr.Length; i++)
    if (arrStr[i].Length <= sizeWord)
        strArr += arrStr[i] + cutChars;

string[] newCutArr = ConcatArrayString(strArr, cutChars);