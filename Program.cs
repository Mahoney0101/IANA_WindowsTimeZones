using System;
using System.Linq;
using NodaTime.TimeZones;


var TzdbIdsToWin = TzdbDateTimeZoneSource.Default.TzdbToWindowsIds;
var WindowsIdToTzdbIds = TzdbDateTimeZoneSource.Default.WindowsToTzdbIds;

string TzdbIdsToWinTxt = "IANA, Windows";
string WindowsIdtoTzdbIdTxt = "Windows, IANA";

TzdbIdsToWin
    .ToList()
    .ForEach(entry => {
        TzdbIdsToWinTxt += String.Format("\n{0},{1}", entry.Key, entry.Value); 
    });

WindowsIdToTzdbIds
    .ToList()
    .ForEach(entry => {
        WindowsIdtoTzdbIdTxt += String.Format("\n{0},{1}", entry.Key, entry.Value);
    });

System.IO.File.WriteAllText("IANAtoWinIds.csv", TzdbIdsToWinTxt);
System.IO.File.WriteAllText("WindowsIdstoIANAs.csv", WindowsIdtoTzdbIdTxt);


