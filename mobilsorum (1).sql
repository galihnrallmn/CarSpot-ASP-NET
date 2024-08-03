-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Waktu pembuatan: 16 Jul 2024 pada 13.05
-- Versi server: 8.0.30
-- Versi PHP: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mobilsorum`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `akunpengguna`
--

CREATE TABLE `akunpengguna` (
  `idakun` int NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` char(60) NOT NULL,
  `level` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data untuk tabel `akunpengguna`
--

INSERT INTO `akunpengguna` (`idakun`, `username`, `password`, `level`) VALUES
(1, 'admin', '$2a$12$jWtc3.VgRsf0d6zsUAVVserJSgMivCO4OBU5vSPv9rM43xR3JdokK', 'admin'),
(2, 'customer', '$2a$12$BxMBkHAEAWk0D17Bh9MNauw3Ts0bXkjMeEj587B1iq/PIWRqwRqYa', 'customer');

-- --------------------------------------------------------

--
-- Struktur dari tabel `member`
--

CREATE TABLE `member` (
  `idmember` int NOT NULL,
  `idakun` int NOT NULL,
  `nama` varchar(50) NOT NULL,
  `nohp` char(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data untuk tabel `member`
--

INSERT INTO `member` (`idmember`, `idakun`, `nama`, `nohp`) VALUES
(1, 1, 'Galih', '089876543412'),
(2, 2, 'Asep', '089876543242');

-- --------------------------------------------------------

--
-- Struktur dari tabel `merek`
--

CREATE TABLE `merek` (
  `idmerek` int NOT NULL,
  `merek` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data untuk tabel `merek`
--

INSERT INTO `merek` (`idmerek`, `merek`) VALUES
(1, 'BMW'),
(2, 'HONDA'),
(3, 'SUZUKI'),
(4, 'TOYOTA'),
(5, 'MITSUBISHI');

-- --------------------------------------------------------

--
-- Struktur dari tabel `mobil`
--

CREATE TABLE `mobil` (
  `idmobil` int NOT NULL,
  `idmerek` int DEFAULT NULL,
  `model` varchar(50) NOT NULL,
  `tahun` varchar(4) NOT NULL,
  `warna` varchar(30) NOT NULL,
  `jaraktempuh` int NOT NULL,
  `tranmisi` varchar(10) NOT NULL,
  `harga` int NOT NULL,
  `foto` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data untuk tabel `mobil`
--

INSERT INTO `mobil` (`idmobil`, `idmerek`, `model`, `tahun`, `warna`, `jaraktempuh`, `tranmisi`, `harga`, `foto`) VALUES
(1, 4, 'Avanza', '2018', 'Putih', 35000, 'Manual', 150000000, 'avanza.jpeg'),
(2, 2, 'Civic', '2019', 'Hitam', 20000, 'Otomatis', 320000000, NULL),
(3, 4, 'Fortuner', '2022', 'Hitam', 20000, 'Automatic', 500000000, NULL),
(5, 1, 'X5', '2020', 'Hitam', 15000, 'Automatic', 900000000, NULL),
(6, 1, '320i', '2018', 'Putih', 30000, 'Manual', 650000000, NULL),
(7, 2, 'Civic', '2019', 'Merah', 20000, 'Automatic', 700000000, NULL),
(8, 2, 'CR-V', '2021', 'Silver', 10000, 'Manual', 800000000, NULL),
(9, 3, 'Swift', '2017', 'Biru', 40000, 'Automatic', 450000000, NULL),
(10, 3, 'Baleno', '2020', 'Hitam', 15000, 'Manual', 550000000, NULL),
(11, 4, 'Corolla', '2019', 'Putih', 20000, 'Automatic', 600000000, NULL),
(12, 4, 'Camry', '2018', 'Silver', 25000, 'Manual', 800000000, NULL),
(13, 5, 'Pajero Sport', '2021', 'Merah', 12000, 'Automatic', 1000000000, NULL),
(14, 5, 'Outlander', '2019', 'Hitam', 30000, 'Manual', 750000000, NULL),
(15, 4, 'Avanza', '2017', 'Putih', 50000, 'Manual', 90000000, 'avanza.jpeg');

-- --------------------------------------------------------

--
-- Struktur dari tabel `penjualan`
--

CREATE TABLE `penjualan` (
  `idpenjualan` int NOT NULL,
  `idmobil` int DEFAULT NULL,
  `idmember` int DEFAULT NULL,
  `tglpenjualan` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Dumping data untuk tabel `penjualan`
--

INSERT INTO `penjualan` (`idpenjualan`, `idmobil`, `idmember`, `tglpenjualan`) VALUES
(14, 2, 2, '2024-07-15'),
(15, 14, 2, '2024-07-01');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `akunpengguna`
--
ALTER TABLE `akunpengguna`
  ADD PRIMARY KEY (`idakun`);

--
-- Indeks untuk tabel `member`
--
ALTER TABLE `member`
  ADD PRIMARY KEY (`idmember`),
  ADD KEY `idakun` (`idakun`);

--
-- Indeks untuk tabel `merek`
--
ALTER TABLE `merek`
  ADD PRIMARY KEY (`idmerek`);

--
-- Indeks untuk tabel `mobil`
--
ALTER TABLE `mobil`
  ADD PRIMARY KEY (`idmobil`),
  ADD KEY `idmerek` (`idmerek`);

--
-- Indeks untuk tabel `penjualan`
--
ALTER TABLE `penjualan`
  ADD PRIMARY KEY (`idpenjualan`),
  ADD KEY `idmobil` (`idmobil`),
  ADD KEY `idpengguna` (`idmember`),
  ADD KEY `idmember` (`idmember`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `akunpengguna`
--
ALTER TABLE `akunpengguna`
  MODIFY `idakun` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT untuk tabel `member`
--
ALTER TABLE `member`
  MODIFY `idmember` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT untuk tabel `merek`
--
ALTER TABLE `merek`
  MODIFY `idmerek` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT untuk tabel `mobil`
--
ALTER TABLE `mobil`
  MODIFY `idmobil` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT untuk tabel `penjualan`
--
ALTER TABLE `penjualan`
  MODIFY `idpenjualan` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `member`
--
ALTER TABLE `member`
  ADD CONSTRAINT `member_ibfk_1` FOREIGN KEY (`idakun`) REFERENCES `akunpengguna` (`idakun`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `mobil`
--
ALTER TABLE `mobil`
  ADD CONSTRAINT `mobil_ibfk_1` FOREIGN KEY (`idmerek`) REFERENCES `merek` (`idmerek`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Ketidakleluasaan untuk tabel `penjualan`
--
ALTER TABLE `penjualan`
  ADD CONSTRAINT `penjualan_ibfk_5` FOREIGN KEY (`idmember`) REFERENCES `member` (`idmember`) ON DELETE SET NULL ON UPDATE CASCADE,
  ADD CONSTRAINT `penjualan_ibfk_6` FOREIGN KEY (`idmobil`) REFERENCES `mobil` (`idmobil`) ON DELETE SET NULL ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
