-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 21, 2026 at 02:44 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `qcu_sdots_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `offense_attachments`
--

CREATE TABLE `offense_attachments` (
  `attachment_id` int(11) NOT NULL,
  `log_id` int(11) NOT NULL,
  `file_name` varchar(255) NOT NULL,
  `file_path` text NOT NULL,
  `file_size_bytes` bigint(20) NOT NULL,
  `uploaded_at` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `offense_attachments`
--

INSERT INTO `offense_attachments` (`attachment_id`, `log_id`, `file_name`, `file_path`, `file_size_bytes`, `uploaded_at`) VALUES
(1, 1, 'incident_report_01.pdf', 'C:\\QCU_SDOTS_Proofs\\incident_report_01.pdf', 524288, '2026-11-21 08:55:32'),
(2, 1, 'corridor_photo_01.jpg', 'C:\\QCU_SDOTS_Proofs\\corridor_photo_01.jpg', 1048576, '2026-11-21 08:55:32'),
(3, 1, 'officer_note_01.docx', 'C:\\QCU_SDOTS_Proofs\\officer_note_01.docx', 262144, '2026-11-21 08:55:32'),
(4, 2, 'littering_proof_01.png', 'C:\\QCU_SDOTS_Proofs\\littering_proof_01.png', 786432, '2026-11-21 08:55:32'),
(5, 2, 'witness_statement_02.pdf', 'C:\\QCU_SDOTS_Proofs\\witness_statement_02.pdf', 409600, '2026-11-21 08:55:32'),
(6, 2, 'guidance_log_02.pdf', 'C:\\QCU_SDOTS_Proofs\\guidance_log_02.pdf', 307200, '2026-11-21 08:55:32'),
(7, 3, 'security_report_03.pdf', 'C:\\QCU_SDOTS_Proofs\\security_report_03.pdf', 614400, '2026-11-21 08:55:32'),
(8, 3, 'cctv_snapshot_03.jpg', 'C:\\QCU_SDOTS_Proofs\\cctv_snapshot_03.jpg', 1572864, '2026-11-21 08:55:32'),
(9, 3, 'parent_notice_03.docx', 'C:\\QCU_SDOTS_Proofs\\parent_notice_03.docx', 358400, '2026-11-21 08:55:32');

-- --------------------------------------------------------

--
-- Table structure for table `offense_logs`
--

CREATE TABLE `offense_logs` (
  `log_id` int(11) NOT NULL,
  `student_id` varchar(30) NOT NULL,
  `offense_type` varchar(255) NOT NULL,
  `custom_specification` varchar(255) DEFAULT '',
  `severity` varchar(20) NOT NULL,
  `warning_level` varchar(30) NOT NULL,
  `incident_date` varchar(20) DEFAULT '',
  `incident_time` varchar(20) DEFAULT '',
  `remarks` text DEFAULT NULL,
  `record_status` varchar(20) DEFAULT 'Active',
  `created_at` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `offense_logs`
--

INSERT INTO `offense_logs` (`log_id`, `student_id`, `offense_type`, `custom_specification`, `severity`, `warning_level`, `incident_date`, `incident_time`, `remarks`, `record_status`, `created_at`) VALUES
(1, '23-1045', 'Minor - c. Disobeying school regulation (loitering in corridors during class, unauthorized use of chalk, etc.)', '', 'Minor', '1st Warning', '11/10/2026', '09:15 AM', 'Found outside classroom during lecture hours.', 'Active', '2026-11-21 08:55:32'),
(2, '24-0821', 'Minor - d. Littering', '', 'Minor', '1st Warning', '11/12/2026', '01:30 PM', 'Left food wrappers near campus bench.', 'Active', '2026-11-21 08:55:32'),
(3, '22-3190', 'Major - x. Smoking inside the university premises', '', 'Major', '1st Warning', '11/15/2026', '03:45 PM', 'Reported by campus security guard.', 'Active', '2026-11-21 08:55:32');

-- --------------------------------------------------------

--
-- Table structure for table `sanctions`
--

CREATE TABLE `sanctions` (
  `sanction_id` int(11) NOT NULL,
  `log_id` int(11) NOT NULL,
  `sanction_type` varchar(100) NOT NULL,
  `status` varchar(30) DEFAULT 'Pending',
  `updated_at` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `completed_hours` int(11) DEFAULT 0,
  `required_hours` int(11) DEFAULT 20,
  `deadline_date` varchar(25) DEFAULT 'Dec 15, 2026',
  `officer_remarks` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sanctions`
--

INSERT INTO `sanctions` (`sanction_id`, `log_id`, `sanction_type`, `status`, `updated_at`, `completed_hours`, `required_hours`, `deadline_date`, `officer_remarks`) VALUES
(1, 1, 'Written Warning', 'Cleared', '2026-11-21 08:55:32', 0, 20, 'Dec 15, 2026', NULL),
(2, 2, 'Community Service', 'Cleared', '2026-11-21 09:08:25', 0, 20, 'Dec 15, 2026', NULL),
(3, 3, 'Suspension', 'Pending', '2026-11-21 08:55:32', 0, 20, 'Dec 15, 2026', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `student_id` varchar(30) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `middle_name` varchar(100) DEFAULT '',
  `department` varchar(120) DEFAULT '',
  `year_level` varchar(50) DEFAULT '',
  `record_status` varchar(20) DEFAULT 'Active',
  `created_at` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`student_id`, `last_name`, `first_name`, `middle_name`, `department`, `year_level`, `record_status`, `created_at`) VALUES
('22-3190', 'Bautista', 'Carlo', 'Reyes', 'College of Business Administration (BSBA)', '4th Year', 'Active', '2026-11-21 08:55:32'),
('23-1045', 'Dela Cruz', 'Juan', 'Abad', 'College of Computer Studies (BSIT)', '3rd Year', 'Active', '2026-11-21 08:55:32'),
('23-2788', 'Torres', 'Miguel', 'Santos', 'College of Computer Studies (BSIS)', '3rd Year', 'Active', '2026-11-21 08:55:32'),
('24-0821', 'Reyes', 'Angela', 'Mae', 'College of Engineering (BSCpE)', '2nd Year', 'Active', '2026-11-21 08:55:32'),
('25-0114', 'Garcia', 'Sofia', 'Lopez', 'College of Education (BSED)', '1st Year', 'Active', '2026-11-21 08:55:32');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` varchar(50) NOT NULL DEFAULT 'Discipline Officer',
  `full_name` varchar(150) DEFAULT '',
  `status` varchar(20) DEFAULT 'Active',
  `created_at` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `password`, `role`, `full_name`, `status`, `created_at`) VALUES
(1, 'admin', 'admin123', 'Admin', 'System Administrator', 'Active', '2026-11-21 08:55:32'),
(2, 'discipline_officer', 'qcu2026', 'Discipline Officer', 'Maria Santos', 'Active', '2026-11-21 08:55:32'),
(3, 'guidance_staff', 'guidance123', 'Guidance Staff', 'Ramon Mendoza', 'Active', '2026-11-21 08:55:32');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `offense_attachments`
--
ALTER TABLE `offense_attachments`
  ADD PRIMARY KEY (`attachment_id`),
  ADD KEY `fk_attach_log` (`log_id`);

--
-- Indexes for table `offense_logs`
--
ALTER TABLE `offense_logs`
  ADD PRIMARY KEY (`log_id`),
  ADD KEY `fk_offense_student` (`student_id`);

--
-- Indexes for table `sanctions`
--
ALTER TABLE `sanctions`
  ADD PRIMARY KEY (`sanction_id`),
  ADD KEY `fk_sanction_log` (`log_id`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`student_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `offense_attachments`
--
ALTER TABLE `offense_attachments`
  MODIFY `attachment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `offense_logs`
--
ALTER TABLE `offense_logs`
  MODIFY `log_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `sanctions`
--
ALTER TABLE `sanctions`
  MODIFY `sanction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `offense_attachments`
--
ALTER TABLE `offense_attachments`
  ADD CONSTRAINT `fk_attach_log` FOREIGN KEY (`log_id`) REFERENCES `offense_logs` (`log_id`) ON DELETE CASCADE;

--
-- Constraints for table `offense_logs`
--
ALTER TABLE `offense_logs`
  ADD CONSTRAINT `fk_offense_student` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`);

--
-- Constraints for table `sanctions`
--
ALTER TABLE `sanctions`
  ADD CONSTRAINT `fk_sanction_log` FOREIGN KEY (`log_id`) REFERENCES `offense_logs` (`log_id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
