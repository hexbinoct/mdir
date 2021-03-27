using System;
using System.Threading;
using System.IO;


namespace mdir
{
  class Program
  {
    static void Main(string[] args)
    {
      //int i = 0;
      //while (true)
      //{
      //  Console.WriteLine(i++);
      //  Thread.Sleep(5000);

      //}
      //return;

      if (args.Length == 0)
      {
        Console.WriteLine("no files?");
        return;


      }

      new folders() { treestructurefile = args[0] }.maketree();

      Console.WriteLine("done.");


    }
  }

  class folders
  {
    public string treestructurefile = "";

    string m_delimpath = "/";
    public void maketree()
    {
      var lines = File.ReadAllLines(this.treestructurefile);
      string currentdirpath = "";

      int tcount = 0;
      for (int i = 0; i < lines.Length; i++)
      {
        var line = lines[i];
        var tempdata = gettabcount(line);

        string tempdirpath = adjust(tempdata.tabcount, currentdirpath);

        tempdirpath += tempdata.dirname + m_delimpath;

        mkdir(tempdirpath);
        currentdirpath = tempdirpath;

        
        /*there are 3 conditions, new line has one more tab, or equal tab, or one or more less tabs.*/
        if (tcount == tempdata.tabcount)
        {

        }

      }
    }
    void mkdir(string path)
    {
      var t = AppDomain.CurrentDomain.BaseDirectory + path.Substring(1);
      Console.WriteLine(path);

      if (!Directory.Exists(t))
        Directory.CreateDirectory(t);

    }
    (string dirname, int tabcount) gettabcount(string line)
    {
      int tcount = 0;
      string dname = "";
      for (int i = 0; i < line.Length; i++)
      {
        if (line[i] == '\t')
          tcount++;
        else
        {
          dname = line.Substring(i);
          break;

        }

      }

      return (dname,tcount);

    }
    string adjust(int tabcount, string line)
    {
      if (tabcount == 0)
        return m_delimpath;
      int x = 0;
      for (int i = 0; i < line.Length; i++)
      {
        if (line[i] == m_delimpath[0])
          x++;

        if (x> tabcount)
        {
          return line.Substring(0, i+1);


        }
      }

      return "";

    }
    // \three\four
  }
}
