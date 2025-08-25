//おみくじ
string[] omikuji = new string[5];
omikuji[0] = "0大吉";
omikuji[1] = "1中吉";
omikuji[2] = "2吉";
omikuji[3] = "3大吉";
omikuji[4] = "4大凶";

//string[] omikuji = { "0大吉", "1中吉", "2吉", "3凶", "4大凶" };

// 各おみくじを何回引いたかを格納する配列
int[] count = new int[5];
//Randomクラスを実体化して変数randが機能を参照できる
Random rand = new Random();

for (int i = 0; i < 100; i++)
{
    int result = rand.Next(0, 5);//０以上５未満のランダムを取得して変数resultに代入

    //result番目の値を配列から引っ張ってきてコンソールに出す
    Console.WriteLine(omikuji[result]);
    //resultで引いた結果の番号を何回引いたかカウント
    count[result]++;
}


// Console.WriteLine("今日の運勢は… " + omikuji[result]);

// for (int i = 0; i < 100; i++)
// {
//     Console.WriteLine("今" + i + "回目の繰り返しです");
// }

Console.WriteLine("\n=== 集計結果 ===");
// 配列countの結果を順番に発表
for (int i = 0; i < omikuji.Length; i++)
{
    Console.WriteLine($"{omikuji[i]}: {count[i]}回");
}
