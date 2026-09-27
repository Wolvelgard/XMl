string pasta = @"C:\Users\WIN11\Downloads\XML\xmlaula";
string[] arquivos = Directory.GetFiles(pasta);

foreach (string arquivo in arquivos)
{
    string xml = arquivo.Substring(37, 44);
    Console.WriteLine(xml);
}