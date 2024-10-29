using AppLogger;
using Humanizer;

string text = "Tässä_on_tosi_paljon_tekstiä!";
Logger.Log(text + "  <-- Logger.Log()-metodia käyttäen");
Console.WriteLine(text.Humanize() + "  <-- Humanize()-metodia käyttäen");
