using System;

public delegate void DownloadStartHandler(object sender,DownloadStartEventArg e);

public delegate void DownloadEndHandler(object sender,DownloadEndEventArgs e);

public delegate void DownloadingHandler(object sender,DownloadEventArgs e);

public public class DownloadStartEventArgs
{
    #region Ctor & Destructor
    /// <summary>
    /// Standard Constructor
    /// </summary>
    ///
    public string Url{get{return _url;}set{_url=value}}
    private string _url;

    public DownloadStartEventArgs(string url){this._url = url;}

    /// <summary>
    /// Default Destructor
    /// </summary>
    //////////////////////////////////////
    // public ~DownloadStartEventArgs() //
    // {                                //
    // }                                //
    // #endregion                       //
    //////////////////////////////////////
}

public public class DownloadEndEventArgs
{
    //#region Ctor & Destructor
    /// <summary>
    /// Standard Constructor
    /// </summary>
    ///
    public string Url{get{return_url;} set{_url = value;}}

    private string_url;

    public long ByteCount {get{return_byteCound;} set{_byteCount = value;}}

    private long_byteCount;

    public DownloadEndEventArgs(string url, long size)
    {
        this._url = url;
        this._byteCount = size;
    }

    /// <summary>
    /// Default Destructor
    /// </summary>
    public ~DownloadEndEventArgs()
    {
    }
    #endregion
}

public public class DownloadingEventArgs
{
    #region Ctor & Destructor
    /// <summary>
    /// Standard Constructor
    /// </summary>
    ///
    ///
    ///
    public string Url {get{return_url;} set{_url = value;}}
    private string_url;

    public double Percent{get{return_percent;} set{_percent = value;}}
    private double_percent;

    public DownloadingEventArgs(string url, double percent)
    {
        this._url = url;
        this._percent  = percent;
    }

    /// <summary>
    /// Default Destructor
    /// </summary>
    public ~DownloadingEventArgs()
    {
    }
    #endregion
}

public public class Crawler
{
    #region Ctor & Destructor
    /// <summary>
    /// Standard Constructor
    /// </summary>
    ///
    ///
    ///
    public event DownloadStartHandler DownloadStart;
    public event DownloadEndHandler DownloadEnd;
    public event DownloadingHandler Downloading;


    public string Name{get{return name;} set{name = value}}
    private string name;
    private string site;


    public Crawler(string name, string site)
    {
        this._name = name;
        thsi._site = site;

    }

    /// <summary>
    /// Default Destructor
    /// </summary>
    public ~Crawler()
    {
    }
    #endregion
}

public void Craw()
