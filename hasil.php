<?php
// menampilkan hasil input
$nama = $_POST ['namaMahasiswa'];
$nilaiMahasiswa = $_POST ['nilaiMahasiswa'];

// hitung nilai

if ($nilaiMahasiswa > 75) {
    $keterangan = "Selamat Anda Lulus";
} else {
    $keterangan = "Maaf Anda Gagal";
}

// menampilkan
echo "Hasil Perhitungan Nilai Mahasiswa<br>";
echo "Nama Mahasiswa : $nama <br>";
echo "Nilai 1 : $nilaiMahasiswa <br>";
echo "Nilai 2 : $nilaiMahasiswa <br>";
echo "Nilai 3 : $nilaiMahasiswa <br>";
echo "Nilai 4 : $nilaiMahasiswa <br>";
echo "Keterangan : $keterangan <br>";