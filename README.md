# LemonWay

Librairies :

Log4Net : pour generer les fichiers de log
Newtonsoft.Json : Pour convertir le Xml en Json


Test :

La solution contient deux projets, un projet Asp.Net s'appelle LemonWay et expose les web services (Fibonacci et XmlToJson),
et un autre projet Console qui s'appelle WebServiceConsumer consomme les web services (Fibonacci et XmlToJson).

L'application console affiche 

Fibonacci(10)
XmlToJson("<foo>bar</foo>")
XmlToJson("<foo>hello</bar>") 
XmlToJson("<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>")

Pour tester l'application console, il faut définir les deux projets comme page de démarrage

Log :

Les fichiers log de l'application web se trouvent dans le repertoire .\LemonWay\Logs
Les fichiers log de l'application console se trouvent dans le repertoire .\LemonWay\WebServiceConsumer\bin\Debug\Logs

Auteur : Sadok Chemli