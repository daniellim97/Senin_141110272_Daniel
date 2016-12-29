-- phpMyAdmin SQL Dump
-- version 4.4.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 29 Des 2016 pada 05.27
-- Versi Server: 5.6.26
-- PHP Version: 5.6.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pos`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `barang`
--

CREATE TABLE IF NOT EXISTS `barang` (
  `ID` int(10) NOT NULL,
  `Kode` varchar(20) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `JumlahAwal` int(10) NOT NULL,
  `HargaHPP` decimal(16,2) NOT NULL,
  `HargaJual` decimal(16,2) NOT NULL,
  `Created_at` datetime NOT NULL,
  `Updated_at` datetime NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `barang`
--

INSERT INTO `barang` (`ID`, `Kode`, `Nama`, `JumlahAwal`, `HargaHPP`, `HargaJual`, `Created_at`, `Updated_at`) VALUES
(1, 'B0001', 'BARANG 1', 0, '10000.00', '15000.00', '2016-12-29 10:53:52', '2016-12-29 10:53:52'),
(2, 'B0002', 'Barang 2', 6, '15000.00', '20000.00', '2016-12-29 10:54:13', '2016-12-29 10:54:13'),
(3, 'B0003', 'Barang 3', 8, '10000.00', '20000.00', '2016-12-29 10:54:42', '2016-12-29 11:10:10');

-- --------------------------------------------------------

--
-- Struktur dari tabel `customer`
--

CREATE TABLE IF NOT EXISTS `customer` (
  `ID` int(10) NOT NULL,
  `Kode` varchar(20) DEFAULT NULL,
  `Nama` varchar(100) DEFAULT NULL,
  `Alamat` varchar(150) DEFAULT NULL,
  `Telp` varchar(20) DEFAULT NULL,
  `Hp` varchar(20) DEFAULT NULL,
  `Created_at` datetime DEFAULT NULL,
  `Updated_at` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `customer`
--

INSERT INTO `customer` (`ID`, `Kode`, `Nama`, `Alamat`, `Telp`, `Hp`, `Created_at`, `Updated_at`) VALUES
(1, 'C0001', 'Customer 1', 'Jalan Lorem Ipsum Customer No. 1', '12345', '', '2016-12-29 10:56:59', '2016-12-29 10:56:59'),
(2, 'C0002', 'Customer 2', 'Jalan Lorem Ipsum Customer No. 2', '', '12345', '2016-12-29 10:57:34', '2016-12-29 10:57:34'),
(3, 'C0003', 'Customer 3', 'Jalan Lorem Ipsum Customer No. 3', '123', '12345', '2016-12-29 10:57:58', '2016-12-29 10:57:58');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pembelian`
--

CREATE TABLE IF NOT EXISTS `pembelian` (
  `ID` int(10) NOT NULL,
  `id_supplier` varchar(10) NOT NULL,
  `id_barang` varchar(10) NOT NULL,
  `namaBarang` varchar(100) NOT NULL,
  `jlhBarang` int(10) NOT NULL,
  `hargaBarang` decimal(16,2) NOT NULL,
  `waktuBeli` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pembelian`
--

INSERT INTO `pembelian` (`ID`, `id_supplier`, `id_barang`, `namaBarang`, `jlhBarang`, `hargaBarang`, `waktuBeli`) VALUES
(1, '1', '1', 'BARANG 1', 1, '15000.00', '2016-12-29 11:24:08'),
(2, '2', '2', 'Barang 2', 1, '20000.00', '2016-12-29 11:24:08');

-- --------------------------------------------------------

--
-- Struktur dari tabel `penjualan`
--

CREATE TABLE IF NOT EXISTS `penjualan` (
  `ID` int(10) NOT NULL,
  `id_customer` varchar(10) NOT NULL,
  `id_barang` varchar(10) NOT NULL,
  `namaBarang` varchar(100) NOT NULL,
  `jlhBarang` int(10) NOT NULL,
  `hargaBarang` decimal(16,2) NOT NULL,
  `waktuJual` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `penjualan`
--

INSERT INTO `penjualan` (`ID`, `id_customer`, `id_barang`, `namaBarang`, `jlhBarang`, `hargaBarang`, `waktuJual`) VALUES
(1, '1', '1', 'BARANG 1', 1, '15000.00', '2016-12-29 11:24:58'),
(2, '1', '1', 'BARANG 1', 1, '15000.00', '2016-12-29 11:24:58'),
(3, '2', '2', 'Barang 2', 1, '20000.00', '2016-12-29 11:24:58');

-- --------------------------------------------------------

--
-- Struktur dari tabel `supplier`
--

CREATE TABLE IF NOT EXISTS `supplier` (
  `ID` int(10) NOT NULL,
  `Kode` varchar(20) DEFAULT NULL,
  `Nama` varchar(100) DEFAULT NULL,
  `Alamat` varchar(150) DEFAULT NULL,
  `Telp` varchar(20) DEFAULT NULL,
  `Hp` varchar(20) DEFAULT NULL,
  `Created_at` datetime DEFAULT NULL,
  `Updated_at` datetime DEFAULT NULL
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `supplier`
--

INSERT INTO `supplier` (`ID`, `Kode`, `Nama`, `Alamat`, `Telp`, `Hp`, `Created_at`, `Updated_at`) VALUES
(1, 'S0001', 'Supplier 1', 'Jalan Lorem Ipsum Supp No. 1', '123', '', '2016-12-29 11:03:40', '2016-12-29 11:03:40'),
(2, 'S0002', 'Supplier 2', 'Jalan Lorem Ipsum Supp No. 2', '', '123', '2016-12-29 11:04:04', '2016-12-29 11:04:04'),
(3, 'S0003', 'Supplier 3', 'Jalan Lorem Ipsum Supp No. 3', '123', '123123', '2016-12-29 11:04:18', '2016-12-29 11:04:18');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `barang`
--
ALTER TABLE `barang`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `pembelian`
--
ALTER TABLE `pembelian`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `barang`
--
ALTER TABLE `barang`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `ID` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=4;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
