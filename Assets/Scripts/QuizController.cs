using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuizController : MonoBehaviour
{
    public GameObject containerSoal, soalTemp;
    public GameObject benar, salah, hasil;

    public GameObject nilaiText;

    // Soal
    private string[] ques =
    {
        "1. James Naismith adalah penemu permainan…",
        "2. Permainan bola basket diciptakan pada tanggal…",
        "3. Pertamakali permainan bola basket di pertandingkan di negara …",
        "4. Induk organisasi bola basket di Internasional adalah…",
        "5. Permainan bola basket dimainkan oleh…",
        "6. Tujuan Permainan bola basket adalah…",
        "7. Teknik yang digunakan mengoper bola jarak dekat dalam permainan bola basket adalah…",
        "8. Cara mengoper bola dengan kedua tangan diatas kepala dengan jari-jari tangan terbuka disebut…",
        "9. Menggiring bola pada permainan bola basket dengan cara…",
        "10. Yang tidak termasuk teknik dasar permainan bola basket adalah …",
        "11. Pandangan mata saat menerima bola dalam permainan bola basket adalah…",
        "12. Tujuan Menggiring bola rendah dalam permainan bola basket adalah…",
        "13. Berapa jumlah wasit dalam permainan bola basket…",
        "14. Seorang pemain tidak boleh menunggu bola di dalam daerah pertahanan lawan lebih dari … detik",
        "15. Pertandingan bola basket dapat dimainkan 2 x 20 menit atau dapat juga dimainkan dengan…",
        "16. Waktu pertandingan bola basket dibagi menjadi … quarter",
        "17. Dalam permainan bola basket lawan akan mendapat poin jika salah satu pemain melakukan pelanggaran sebanyak … kali berturut-turut",
        "18. Bola basket terbuat dari…",
        "19. Diameter lingkaran keranjang (ring) basket adalah…",
        "20. Panjang dan lebar lapangan bola basket dalam standar internasional adalah…"
    };

    private string[] ansA =
    {
        "Sepak Bola",
        "20 desember 1876",
        "20 desember 1876",
        "FIFA",
        "1 regu",
        "Memasukkan bola ke ring lawan",
        "Chest pass",
        "Chest pass",
        "Memanantul-mantul kan bola di lantai",
        "Dribbling",
        "Ke arah datangnya bola",
        "Mempercepat penyerangan",
        "3 orang",
        "3",
        "4x 8 menit",
        "4",
        "Dua",
        "Karet dan bahan sintetis",
        "40 cm",
        "26x14m"
    };

    private string[] ansB =
    {
        "Bola Voli",
        "21 april 1891",
        "Jerman",
        "FIBA",
        "3 regu",
        "Menjaga daerah pertahanan",
        "Jeveline pass",
        "Jeveline pass",
        "Melempar bola ke lantai",
        "Passing",
        "Ke samping",
        "Memperlambat permainan",
        "4 orang",
        "5",
        "4x 10 menit",
        "5",
        "Tiga",
        "Plastik",
        "45 cm",
        "26x15m"
    };

    private string[] ansC =
    {
        "Bola Basket",
        "15 desember 1891",
        "Belanda",
        "BWF",
        "2 regu",
        "Menunjukkan teknik yang indah",
        "Bounce pass",
        "Bounce Pass",
        "Memukul bola ke lantai",
        "Servis",
        "Ke teman",
        "Mempertahankan bola dari serangan lawan",
        "5 orang",
        "10",
        "4x 12 menit",
        "6",
        "Empat",
        "Kain",
        "50 cm",
        "14x25m"
    };

    private string[] ansD =
    {
        "Kasti",
        "29 maret 1877",
        "Perancis",
        "FIG",
        "Bersama",
        "Memasukkan bola ke ring lawan dn mempertahankan daerah sendiri",
        "Overhead pass",
        "Overhead pass",
        "Menendang bola",
        "Catching",
        "Ke atas",
        "Mengontrol bola di daerah lawan",
        "2 orang",
        "30",
        "4x 15 menit",
        "7",
        "Lima",
        "Kayu",
        "55 cm",
        "15x25m"
    };

    private string[] kunci =
    {
        "C",
        "C",
        "B",
        "B",
        "C",
        "D",
        "A",
        "D",
        "A",
        "C",
        "A",
        "C",
        "A",
        "A",
        "B",
        "A",
        "B",
        "A",
        "B",
        "A"
    };
    private GameObject[] daftarSoal = new GameObject[20];

    private bool ansCheck = false;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetInt("SekarangSoal", 1);
        for (int i=0; i < ques.Length; i++)
        {
            // Create All soal
            GameObject soal = Instantiate(soalTemp, containerSoal.transform) as GameObject;
            daftarSoal[i] = soal;
            // soal
            GameObject quest = soal.transform.GetChild(1).transform.GetChild(1).gameObject;
            quest.GetComponent<Text>().text = ques[i];
            // ans A
            soal.transform.GetChild(2).GetComponent<Button>().onClick.AddListener(delegate { OnPilih("A", soal, 2); });
            soal.transform.GetChild(2).transform.GetChild(2).GetComponent<Text>().text = ansA[i];
            // ans B
            soal.transform.GetChild(3).GetComponent<Button>().onClick.AddListener(delegate { OnPilih("B", soal, 3); });
            soal.transform.GetChild(3).transform.GetChild(2).GetComponent<Text>().text = ansB[i];
            // ans C
            soal.transform.GetChild(4).GetComponent<Button>().onClick.AddListener(delegate { OnPilih("C", soal, 4); });
            soal.transform.GetChild(4).transform.GetChild(2).GetComponent<Text>().text = ansC[i];
            // ans D
            soal.transform.GetChild(5).GetComponent<Button>().onClick.AddListener(delegate { OnPilih("D", soal, 5); });
            soal.transform.GetChild(5).transform.GetChild(2).GetComponent<Text>().text = ansD[i];
            soal.name = "Soal ("+(i+1).ToString()+")";
            soal.transform.localScale = Vector3.one;
            soal.transform.SetParent(containerSoal.transform);
            PlayerPrefs.SetString("kunci-" + (i+1).ToString(), kunci[i]);
            if (PlayerPrefs.GetInt("SekarangSoal") == (i+1))
            {
                soal.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnPilih(string huruf, GameObject tempSoal, int btn)
    {
        string noSoal = tempSoal.name.Substring(6, 1);
        if  (PlayerPrefs.GetInt("SekarangSoal") > 9)
        {
            noSoal = tempSoal.name.Substring(6, 2);
        }
        PlayerPrefs.SetString("Ans" + noSoal, huruf);
        print(PlayerPrefs.GetString("Ans" + noSoal).ToString());
        for (int i = 2; i <= 5; i++)
        {
            tempSoal.transform.GetChild(i).transform.GetChild(0).GetComponent<Image>().color = Color.white;
        }
        tempSoal.transform.GetChild(btn).transform.GetChild(0).GetComponent<Image>().color = Color.green;
    }


    public void toHome()
    {
        new ButtonEffectController().onClick();
        SceneManager.LoadScene("Menu");
    }


    public GameObject keluar;

    public void toKeluar()
    {
        new ButtonEffectController().onClick();
        keluar.SetActive(true);
    }

    public void toBenar()
    {
        benar.SetActive(true);
        salah.SetActive(false);
        hasil.SetActive(false);
    }

    public void toSalah()
    {
        benar.SetActive(false);
        salah.SetActive(true);
        hasil.SetActive(false);
    }

    public void toHasil()
    {
        int nilai = 0;
        for (int i = 1; i <= 20; i++)
        {
            if (PlayerPrefs.GetString("Ans"+i) == kunci[i - 1])
            {
                nilai += 5;
            }
        }
        nilaiText.GetComponent<Text>().text = nilai.ToString();
        benar.SetActive(false);
        salah.SetActive(false);
        hasil.SetActive(true);
    }

    public void toLanjut()
    {
        print(PlayerPrefs.GetInt("SekarangSoal").ToString());
        print(PlayerPrefs.GetString("Ans" + PlayerPrefs.GetInt("SekarangSoal").ToString()) + "Kunci" + kunci[PlayerPrefs.GetInt("SekarangSoal") - 1]);
        // Cek Jawaban
        if (PlayerPrefs.GetString("Ans"+PlayerPrefs.GetInt("SekarangSoal").ToString()) == kunci[PlayerPrefs.GetInt("SekarangSoal") - 1])
        {
            toBenar();
        }
        else
        {
            toSalah();
        }
    }

    public void toSoalBerikutnya()
    {
        benar.SetActive(false);
        salah.SetActive(false);
        hasil.SetActive(false);
        // Next Soal
        int next = PlayerPrefs.GetInt("SekarangSoal") + 1;
        if (next > 20)
        {
            toHasil();
            return;
        }
        for (int i = 1; i <= 20; i++)
        {
            containerSoal.transform.GetChild(i).gameObject.SetActive(false);
        }
        containerSoal.transform.GetChild(next).gameObject.SetActive(true);
        PlayerPrefs.SetInt("SekarangSoal", next);
    }
}
