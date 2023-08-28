USE GalloTubeDb;

INSERT INTO Tag(Id, Name) VALUES
(1, "#Em Alta"),
(2, "#Shopping"),
(4, "#Música"),
(5, "#Filmes"),
(6, "#Ao Vivo"),
(7, "#Jogos"),
(8, "#Notícias"),
(9, "#Esportes"),
(10, "#Aprender");

INSERT INTO Video VALUES
(1, "Taylor Swift - Blank Space", "
►Exclusive Merch: https://store.taylorswift.com
 
►Follow Taylor Swift Online
Instagram: http://www.instagram.com/taylorswift
Facebook: http://www.facebook.com/taylorswift
Tumblr: http://taylorswift.tumblr.com
Twitter: http://www.twitter.com/taylorswift13
Website: http://www.taylorswift.com
 
►Follow Taylor Nation Online
Instagram: http://www.instagram.com/taylornation
Tumblr: http://taylornation.tumblr.com
Twitter: http://www.twitter.com/taylornation13", 

"2014-11-10 00:21:21", 04, "\\img\\videos\\01.jpg", "https://youtu.be/e-ORhEE9VVg");

INSERT INTO VideoTag VALUES
(1, 4);