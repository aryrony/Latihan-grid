-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 05 Jul 2021 pada 15.15
-- Versi server: 10.4.14-MariaDB
-- Versi PHP: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_kasir`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_barang`
--

CREATE TABLE `tbl_barang` (
  `Barcode` char(50) NOT NULL,
  `Nama_Barang` varchar(100) NOT NULL,
  `Harga_Beli` double NOT NULL,
  `Harga_Jual` double NOT NULL,
  `Selisih_Harga` double NOT NULL,
  `Stok` int(20) NOT NULL,
  `ID_Jenis` char(20) NOT NULL,
  `ID_Satuan` char(20) NOT NULL,
  `ID_Merek` char(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_barang`
--

INSERT INTO `tbl_barang` (`Barcode`, `Nama_Barang`, `Harga_Beli`, `Harga_Jual`, `Selisih_Harga`, `Stok`, `ID_Jenis`, `ID_Satuan`, `ID_Merek`) VALUES
('12121212', 'asfsafasf', 12, 13, 1, 10, 'IDJ-121212', 'IDS-121212', 'IDM-121212'),
('170821', 'apa sih kawan', 19000, 25000, 6000, 5, 'IDJ-22621105357', 'IDS-1462134830', 'IDM-1462134856'),
('170821', 'apa sih kawan', 19000, 25000, 6000, 5, 'IDJ-22621105357', 'IDS-1462134830', 'IDM-1462134856');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_jenis`
--

CREATE TABLE `tbl_jenis` (
  `ID_jenis` char(20) NOT NULL,
  `Jenis` char(20) NOT NULL,
  `Keterangan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_jenis`
--

INSERT INTO `tbl_jenis` (`ID_jenis`, `Jenis`, `Keterangan`) VALUES
('IDJ-22621105357', 'pilih', 'apa'),
('IDJ121212', 'makanan', 'makanan penutup');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_merek`
--

CREATE TABLE `tbl_merek` (
  `ID_merek` char(20) NOT NULL,
  `Merek` char(20) NOT NULL,
  `Keterangan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_merek`
--

INSERT INTO `tbl_merek` (`ID_merek`, `Merek`, `Keterangan`) VALUES
('IDM-1462134856', 'AHHA', 'AH SIAP'),
('IDM676777', 'ELVI', 'Branded');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_penjualan`
--

CREATE TABLE `tbl_penjualan` (
  `ID_Penjualan` char(20) NOT NULL,
  `Pelanggan` char(20) NOT NULL,
  `Tgl_transaksi` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_penjualan`
--

INSERT INTO `tbl_penjualan` (`ID_Penjualan`, `Pelanggan`, `Tgl_transaksi`) VALUES
('121212', 'umum', '2021-07-05');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_penjualan_detail`
--

CREATE TABLE `tbl_penjualan_detail` (
  `ID_Transaksi` char(20) NOT NULL,
  `ID_Penjualan` char(20) NOT NULL,
  `Barcode` char(20) NOT NULL,
  `Nama_Barang` varchar(50) NOT NULL,
  `Harga_Jual` double NOT NULL,
  `Qty` int(20) NOT NULL,
  `Sub_Total` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_satuan`
--

CREATE TABLE `tbl_satuan` (
  `ID_satuan` char(20) NOT NULL,
  `satuan` char(20) NOT NULL,
  `Keterangan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_satuan`
--

INSERT INTO `tbl_satuan` (`ID_satuan`, `satuan`, `Keterangan`) VALUES
('IDS-1462134830', 'asssssd', 'wasss'),
('IDS121212', 'as', 'as');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_jenis`
--
ALTER TABLE `tbl_jenis`
  ADD PRIMARY KEY (`ID_jenis`);

--
-- Indeks untuk tabel `tbl_merek`
--
ALTER TABLE `tbl_merek`
  ADD PRIMARY KEY (`ID_merek`);

--
-- Indeks untuk tabel `tbl_penjualan`
--
ALTER TABLE `tbl_penjualan`
  ADD PRIMARY KEY (`ID_Penjualan`);

--
-- Indeks untuk tabel `tbl_penjualan_detail`
--
ALTER TABLE `tbl_penjualan_detail`
  ADD PRIMARY KEY (`ID_Transaksi`);

--
-- Indeks untuk tabel `tbl_satuan`
--
ALTER TABLE `tbl_satuan`
  ADD PRIMARY KEY (`ID_satuan`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
