using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainscript : MonoBehaviour
{
    public Text Remark;//テキストに文字を表示
    public Text Name;

    public GameObject[] BackGround;
    public GameObject[] Character;// 0ヒロイン　1ギルド長
    private float time = 10f;

    public AudioClip[] Bois;
    AudioSource AScore;


    private int SC;

    // Start is called before the first frame update
    void Start()
    {
        SC = 0;
        AScore = GetComponent<AudioSource>();
        List();
        Name.text = "";
        Remark.text = "";
        BackGround[5].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            SC += 1;
            TolkTable(SC);
        }
        if (Input.GetMouseButtonDown(1))
        {
            SC -= 1;
            TolkTable(SC);
        }
        
    }

    public void TolkTable(int SC){
        Debug.Log(SC);

        switch (SC)
        {
            case 0:
                List();
                Name.text = "";
                Remark.text = "";
                //Character[3].SetActive(true);
                //AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 1:
                List();
                Name.text = "学園長";
                Remark.text = "「君たちのこれからの活躍に期待している」";
                BackGround[1].SetActive(true);
                Character[3].SetActive(true);
                AScore.PlayOneShot(Bois[SC-1]);
                break;
            case 2:
                List();
                Name.text = "";
                Remark.text = "その言葉で締めくくられた高等学部入学式は、特に問題もなく閉会を迎えた。";
                BackGround[1].SetActive(true);
                //Character[0].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 3:
                List();
                Name.text = "主人公";
                Remark.text = "「なんでこう、偉い人の話は長いんだろうか、、、」";
                BackGround[1].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 4:
                List();
                Name.text = "";
                Remark.text = "僕がそう心の中でぼやいていると";
                BackGround[1].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 5:
                List();
                Name.text = "？？？";
                Remark.text = "「こっちだよーー！！」";
                BackGround[1].SetActive(true);
                Character[5].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 6:
                List();
                Name.text = "";
                Remark.text = "と少し離れた壁沿いの方から聞きなれた声が聞こえた。";
                BackGround[1].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 7:
                List();
                Name.text = "";
                Remark.text = "僕がその声がしたほうに向かうと、幼馴染である少女が立っていた。";
                BackGround[1].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 8:
                List();
                Name.text = "幼馴染";
                Remark.text = "「一緒に帰ろ？」";
                BackGround[1].SetActive(true);
                Character[0].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 9:
                List();
                Name.text = "主人公";
                Remark.text = "「あぁ、そうだね」";
                BackGround[1].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 10:
                List();
                Name.text = "";
                Remark.text = "そう僕が返すと、幼馴染は俺の手を引いて出口に向かって引っ張ってきた。";
                BackGround[1].SetActive(true);
                Character[0].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 11:
                List();
                Name.text = "";
                Remark.text = "そしてそのまま帰りの汽車まで引っ張られ続けるのであった。";
                BackGround[1].SetActive(true);
                Character[0].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 12:
                List();
                Name.text = "";
                Remark.text = "乗り込んだ汽車の客室の中、2人で話をしていた時に事件は起きた。";
                BackGround[3].SetActive(true);
                //Character[0].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 13:
                List();
                Name.text = "アラーム";
                Remark.text = "「ビィィィィイ、ビィィィィイーーー！」";
                BackGround[3].SetActive(true);
                Character[0].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 14:
                List();
                Name.text = "";
                Remark.text = "甲高いアラームの音が車内に鳴り響く。その後車内アナウンスで";
                BackGround[3].SetActive(true);
                Character[0].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 15:
                List();
                Name.text = "アナウンス";
                Remark.text = "「ただいまトラブルが発生いたしました。係りの者が対応しておりますので、そのままでお待ちくださいませ」";
                BackGround[3].SetActive(true);
                Character[5].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 16:
                List();
                Name.text = "";
                Remark.text = "そうアナウンスされたが汽車が止まる気配はなかった。通常アラームが鳴った場合は汽車を停止させるのが一般だ。だがこの汽車は特に速度を緩めることなく進んでいる。";
                BackGround[3].SetActive(true);
                //Character[0].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 17:
                List();
                Name.text = "";
                Remark.text = "さっきのアラームは緊急用アラームの中でも危険度が高い故障時になるアラーム音だ。昔に1度だけ聞いたことがある、、、まだ自分は幼かったけど、あのアラームの音だけは忘れない、、、絶対に忘れられないアラーム音だ。。";
                BackGround[3].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 18:
                List();
                Name.text = "幼馴染";
                Remark.text = "「おーいー大丈夫？？」";
                BackGround[3].SetActive(true);
                Character[0].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 19:
                List();
                Name.text = "";
                Remark.text = "目の前で手を振られ気づいた。過去のことを思い出しているうちにボーっとしてしまったらしい。";
                BackGround[3].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 20:
                List();
                Name.text = "幼馴染";
                Remark.text = "「どうしたの？」";
                BackGround[3].SetActive(true);
                Character[0].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 21:
                List();
                Name.text = "";
                Remark.text = "僕は小声で";
                BackGround[3].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 22:
                List();
                Name.text = "主人公";
                Remark.text = "「あぁ。大丈夫だよ。ただ、アラームが鳴ったのに汽車が停止しない。多分機関車の方で何かしらの問題が起こったんだと思う。簡単なトラブルなら運転手達で直せるけど、これでも蒸気技師の卵だからね。念のためにも機関車に向かおうってわけだよ」";
                BackGround[3].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 23:
                List();
                Name.text = "";
                Remark.text = "そう彼女には伝えたがほぼ100％運転手達では手に負えない故障だろう。僕は汽車の発車停車を行っている機関車の方で問題が起こったのだと考え、彼女の手を引きながら前方に向って歩き出した。";
                BackGround[3].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 24:
                List();
                Name.text = "主人公";
                Remark.text = "「機関車はこのすぐ先の車両だね。行こうか」";
                BackGround[3].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 25:
                List();
                Name.text = "";
                Remark.text = "機関車に近づくにつれ中から怒鳴り声とあわただしい声が聞こえてきた。";
                BackGround[3].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 26:
                List();
                Name.text = "偉い人";
                Remark.text = "「だから、早く直せ！これでは取引に間に合わないではないか！！人を運ぶのがお前らの仕事だろう！！」";
                BackGround[3].SetActive(true);
                Character[5].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 27:
                List();
                Name.text = "";
                Remark.text = "そんな怒鳴り声が機関車の中から響いてきたが、お構いなしに自分たちは機関室に入った。";
                BackGround[2].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 28:
                List();
                Name.text = "運転手";
                Remark.text = "「なんだい君たちは！ここは立ち入り禁止だ！君たちみたいな子供が入る場所ではない、、ぞ、、、」";
                BackGround[2].SetActive(true);
                Character[4].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 29:
                List();
                Name.text = "";
                Remark.text = "そう運転手の1人に怒鳴られたが、自分たちの制服を見て気づいたのか語尾が弱くなっていた。";
                BackGround[2].SetActive(true);
                Character[4].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 30:
                List();
                Name.text = "主人公";
                Remark.text = "「自分たちは蒸気技師学園の学生です。緊急のアラームが鳴りましたので、何かお力になれればと、機関車まで来たのですが」";
                BackGround[2].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 31:
                List();
                Name.text = "";
                Remark.text = "そういうとその運転手は先のドアを通り消えていった。あの先は動力室なはずだ。おそらく車掌に聞きに行ったのだろう。";
                BackGround[2].SetActive(true);
                //Character[0].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 32:
                List();
                Name.text = "";
                Remark.text = "少ししたら中から先ほどの運転手が出てきて";
                BackGround[2].SetActive(true);
                Character[4].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 33:
                List();
                Name.text = "運転手";
                Remark.text = "「先ほどはすまなかった。先ほどからあの客のせいでイラついててな。こっちに来てほしい」";
                BackGround[2].SetActive(true);
                Character[4].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 34:
                List();
                Name.text = "";
                Remark.text = "と、自分たちを機関室に連れて行ってくれた。";
                BackGround[2].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 35:
                List();
                Name.text = "運転手";
                Remark.text = "「車掌！蒸気技師学園の学生を連れてまいりました。」";
                BackGround[4].SetActive(true);
                Character[4].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 36:
                List();
                Name.text = "";
                Remark.text = "機関室はひどい有様だった。3つあるメイン蒸気機関がすべて破裂しており、予備であるサブ蒸気機関1つしか動いておらず、そのサブも数か所から蒸気を噴き出していた。";
                BackGround[4].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 37:
                List();
                Name.text = "";
                Remark.text = "機関室には自分達を連れてきてくれた運転手。ゴリゴリマッチョの車掌と思わしき人。それ以外にもあと2人がサブ機関の蒸気を止めようと必死に作業をしていた。";
                BackGround[4].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
                
            case 38:
                List();
                Name.text = "車掌";
                Remark.text = "「おぉ。君たちが蒸気技師学園の学生か！正直もう我々ではどうにもならんのだ。このままではこの後の下り坂でブレーキをかけることが出来ず、脱線してしまう！」";
                BackGround[4].SetActive(true);
                Character[2].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 39:
                List();
                Name.text = "";
                Remark.text = "機関室に入って早々に車掌にそういわれた。";
                BackGround[4].SetActive(true);
                Character[2].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 40:
                List();
                Name.text = "";
                Remark.text = "現代の汽車では発車から停車まで加速から減速すべて蒸気機関を使用することにより行っている。そのため蒸気機関が使用できなくなると制御が不可能になってしまう。";
                BackGround[4].SetActive(true);
                //Character[0].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 41:
                List();
                Name.text = "主人公";
                Remark.text ="「わかりました。メイン蒸気機関を1機修理します。他の方はそのままサブ機関の修理をお願いします」";
                BackGround[4].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 42:
                List();
                Name.text = "";
                Remark.text = "僕は運転手の人たちにそういうとメイン機関の修理に取り掛かった。";
                BackGround[4].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 43:
                List();
                Name.text = "";
                Remark.text = "幸い重症な個所は少なく、修理は問題なく終わりそうだった。幼馴染に協力してもらいながら修理していたが、僕はこのトラブルが人的に起こされたものなのではないかと思い始めていた。";
                BackGround[4].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 44:
                List();
                Name.text = "";
                Remark.text = "先ほども言ったが、汽車はすべての制御を蒸気機関が行っている。そのため蒸気機関が使用できないという事態は絶対に避けなければいけないことであり、いくつもの安全対策が取られている。";
                BackGround[4].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 45:
                List();
                Name.text = "";
                Remark.text = "そしてその対策の1つとして、汽車には1台で発車から停車まですべて行える蒸気機関が3台も積み込まれている。基本的にはその3台を出力30%ですべて動かしながら汽車は動いている。";
                BackGround[4].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 46:
                List();
                Name.text = "";
                Remark.text = "しかし今回はその3台すべてが故障している。今までそのような事故はほとんど聞いたことが無いし、少なくともここ数年は起こっていない。";
                BackGround[4].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 47:
                List();
                Name.text = "";
                Remark.text = "と、考えている間にいつの間にか修理は終わっていた。";
                BackGround[4].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 48:
                List();
                Name.text = "主人公";
                Remark.text = "「運転手の皆さんどうですか？動きそうですか？」";
                BackGround[4].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 49:
                List();
                Name.text = "運転手";
                Remark.text = "「あ、ああぁ！！動く、これなら大丈夫だ！！君たち本当にありがとう！申し訳ないんだが次の停車駅までここにいてもらえないだろうか？」";
                BackGround[4].SetActive(true);
                Character[4].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 50:
                List();
                Name.text = "主人公";
                Remark.text = "「わかりました。後ろの運転室にいますので何かあったら呼んでください」";
                BackGround[4].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 51:
                List();
                Name.text = "車掌";
                Remark.text = "「あぁ、分かった。」";
                BackGround[4].SetActive(true);
                Character[4].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 52:
                List();
                Name.text = "";
                Remark.text = "そういわれて幼馴染とともに機関室を出た俺の手は震えていた。";
                BackGround[2].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 53:
                List();
                Name.text = "幼馴染";
                Remark.text = "「どうしたの？」";
                BackGround[2].SetActive(true);
                Character[0].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 54:
                List();
                Name.text = "";
                Remark.text = "幼馴染にはそう聞かれたが僕は";
                BackGround[2].SetActive(true);
                Character[0].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 55:
                List();
                Name.text = "主人公";
                Remark.text = "「なんでもないよ、、、」";
                BackGround[2].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 56:
                List();
                Name.text = "";
                Remark.text = "と返すしかなかった。";
                BackGround[2].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 57:
                List();
                Name.text = "主人公";
                Remark.text = "（あの事故が人的に起こされたものだとしたら、、、僕は昔に今回の事故に似た事故を見たことがある、、、もし本当に人的なものだとしたら、、過去のあの事故ももしかしたら、、、）";
                BackGround[2].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 58:
                List();
                Name.text = "";
                Remark.text = "しばらくしてついた駅には自分たちの親が待っていた。";
                BackGround[0].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 59:
                List();
                Name.text = "主人公";
                Remark.text = "（もしかしたら父さんは、、、）";
                BackGround[0].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
            case 60:
                List();
                Name.text = "";
                Remark.text = "僕は母さんを見ながら今回の事故、そして過去の事件を思い返していた。";
                BackGround[0].SetActive(true);
                Character[1].SetActive(true);
                AScore.PlayOneShot(Bois[SC - 1]);
                break;
                break;


        }
    }

    public void GameLine(string word)
    {
        //stringに入った一連の文字列を１つづつ配列に入れる
        char[] nobl = new char[word.Length];
        for(int lp = 0; lp < word.Length; lp++)//nobl[]に文字を入れる
        {
            nobl[lp] = word[lp];
        }

        string texts = ""; //話し言葉を順次格納する変数

        int i = 0;
        float alltime = 0;
        do
        {
            alltime += Time.deltaTime;
            if (alltime >= time)
            {
                Debug.Log(alltime + "   " + texts);
                texts = texts + nobl[i];
                i++;
                alltime = 0;
                Remark.text = texts;
            }
        } while (i < word.Length+2);
        
    }

    public void List()
    {
        for(int lp = 0; lp < BackGround.Length; lp++)
        {
            BackGround[lp].SetActive(false);
        }
        for (int lp = 0; lp < Character.Length; lp++)
        {
            Character[lp].SetActive(false);
        }

        AScore.Stop();
    }
}

