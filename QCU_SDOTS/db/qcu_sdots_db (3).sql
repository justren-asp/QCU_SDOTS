-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 28, 2026 at 05:00 AM
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
  `file_path` varchar(500) NOT NULL,
  `file_size_bytes` bigint(20) NOT NULL DEFAULT 0,
  `uploaded_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `offense_category`
--

CREATE TABLE `offense_category` (
  `id` int(11) NOT NULL,
  `description` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `offense_category`
--

INSERT INTO `offense_category` (`id`, `description`) VALUES
(0, 'Minor Offense'),
(1, 'Major Offense');

-- --------------------------------------------------------

--
-- Table structure for table `offense_logs`
--

CREATE TABLE `offense_logs` (
  `log_id` int(11) NOT NULL,
  `student_id` varchar(20) NOT NULL,
  `category_id` int(11) NOT NULL,
  `specific_offense_id` int(11) NOT NULL,
  `warning_id` varchar(10) NOT NULL,
  `offense_type` varchar(255) NOT NULL,
  `custom_specification` varchar(255) DEFAULT '',
  `severity` varchar(20) NOT NULL,
  `warning_level` varchar(50) NOT NULL,
  `incident_date` varchar(20) NOT NULL,
  `incident_time` varchar(20) NOT NULL,
  `remarks` text DEFAULT NULL,
  `record_status` varchar(20) NOT NULL DEFAULT 'Active',
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `offense_logs`
--

INSERT INTO `offense_logs` (`log_id`, `student_id`, `category_id`, `specific_offense_id`, `warning_id`, `offense_type`, `custom_specification`, `severity`, `warning_level`, `incident_date`, `incident_time`, `remarks`, `record_status`, `created_at`) VALUES
(1, '24-1001', 0, 1, 'A', 'Minor - Dress Code / Improper Uniform Compliance', NULL, 'Minor', '1st Warning', '11/10/2026', '09:15 AM', 'Reported without ID/uniform at gate.', 'Active', '2026-11-28 03:00:24'),
(2, '24-1002', 0, 2, 'B', 'Minor - Tardiness / Habitual Late Arrival', NULL, 'Minor', '2nd Warning', '11/14/2026', '08:05 AM', 'Late for morning class multiple times.', 'Active', '2026-11-28 03:00:24'),
(3, '24-1003', 1, 10, 'C', 'Major - Academic Dishonesty / Unauthorized Material', NULL, 'Major', '3rd Warning', '11/18/2026', '01:30 PM', 'Referred to disciplinary board for review.', 'Active', '2026-11-28 03:00:24'),
(4, '24-1004', 0, 4, 'B', 'Minor - Littering / Improper Waste Disposal', NULL, 'Minor', '2nd Warning', '11/02/2026', '02:45 PM', 'Past due for sanction completion.', 'Active', '2026-11-28 03:00:24');

-- --------------------------------------------------------

--
-- Table structure for table `offense_specific`
--

CREATE TABLE `offense_specific` (
  `id` int(11) NOT NULL,
  `category_id` int(11) NOT NULL,
  `description` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `offense_specific`
--

INSERT INTO `offense_specific` (`id`, `category_id`, `description`) VALUES
(1, 0, 'Dress Code / Improper Uniform Compliance'),
(2, 0, 'Improper Wearing or Non-Display of School ID'),
(3, 0, 'Disobeying School Regulation (Loitering / Corridor Disturbance)'),
(4, 0, 'Littering or Improper Waste Disposal'),
(5, 0, 'Unreturned Borrowed Equipment / Classroom Misuse'),
(6, 0, 'Others'),
(7, 1, 'Academic Dishonesty (Cheating / Plagiarism / Falsification)'),
(8, 1, 'Vandalism or Destruction of University Property'),
(9, 1, 'Bullying, Harassment, or Threatening Behavior'),
(10, 1, 'Theft, Extortion, or Unauthorized Possession'),
(11, 1, 'Smoking, Alcohol, or Prohibited Substances on Campus'),
(12, 1, 'Third Accumulated Minor Offense (Automatic Escalation)'),
(13, 1, 'Others');

-- --------------------------------------------------------

--
-- Table structure for table `sanctions`
--

CREATE TABLE `sanctions` (
  `sanction_id` int(11) NOT NULL,
  `log_id` int(11) NOT NULL,
  `warning_specific_id` int(11) DEFAULT NULL,
  `sanction_type` varchar(150) NOT NULL,
  `completed_hours` int(11) NOT NULL DEFAULT 0,
  `required_hours` int(11) NOT NULL DEFAULT 20,
  `deadline_date` varchar(25) DEFAULT 'Dec 15, 2026',
  `officer_remarks` text DEFAULT NULL,
  `status` varchar(20) NOT NULL DEFAULT 'Pending',
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sanctions`
--

INSERT INTO `sanctions` (`sanction_id`, `log_id`, `warning_specific_id`, `sanction_type`, `completed_hours`, `required_hours`, `deadline_date`, `officer_remarks`, `status`, `updated_at`) VALUES
(1, 1, 1, 'Written Warning / Reprimand', 0, 0, 'Dec 15, 2026', 'Initial warning issued.', 'Pending', '2026-11-28 03:00:24'),
(2, 2, 2, 'Community Service', 12, 20, 'Dec 15, 2026', 'Completed 12 hrs in campus grounds.', 'Pending', '2026-11-28 03:02:53'),
(3, 3, 8, 'Disciplinary Board Referral', 0, 0, 'Dec 10, 2026', 'Awaiting board schedule.', 'Escalated', '2026-11-28 03:00:24'),
(4, 4, 2, 'Community Service', 5, 20, 'Nov 20, 2026', 'Deadline passed; follow up with student.', 'Overdue', '2026-11-28 03:00:24');

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `student_id` varchar(20) NOT NULL,
  `last_name` varchar(80) NOT NULL,
  `first_name` varchar(80) NOT NULL,
  `middle_name` varchar(80) DEFAULT '',
  `department` varchar(120) NOT NULL,
  `section` varchar(30) NOT NULL,
  `record_status` varchar(20) NOT NULL DEFAULT 'Active',
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`student_id`, `last_name`, `first_name`, `middle_name`, `department`, `section`, `record_status`, `created_at`) VALUES
('21-0001', 'Dela Cruz', 'Juan', 'A.', 'College of Computer Studies (BSIT)', 'SBIT-3A', 'Active', '2026-11-27 23:27:28'),
('21-0002', 'Santos', 'Maria', 'C.', 'College of Computer Studies (BSIS)', 'SBIS-2B', 'Active', '2026-11-27 23:27:28'),
('21-0210', 'Bautista', 'Anne', 'P.', 'College of Engineering (BSCpE)', 'SBCS-1B', 'Active', '2026-11-27 23:27:28'),
('24-1001', 'Santos', 'Maria', 'Cruz', 'BS Information Technology', 'BSIT-3A', 'Active', '2026-11-28 03:00:24'),
('24-1002', 'Reyes', 'Juan', 'dela Cruz', 'BS Computer Science', 'BSCS-2B', 'Active', '2026-11-28 03:00:24'),
('24-1003', 'Mendoza', 'Angela', 'Lim', 'BS Accountancy', 'BSA-1A', 'Active', '2026-11-28 03:00:24'),
('24-1004', 'Bautista', 'Carlo', 'Ramos', 'BS Hospitality Management', 'BSHM-3C', 'Active', '2026-11-28 03:00:24');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password_hash` varchar(255) NOT NULL,
  `full_name` varchar(120) NOT NULL,
  `role` varchar(50) NOT NULL DEFAULT 'Discipline Officer',
  `is_active` tinyint(1) NOT NULL DEFAULT 1,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `password_hash`, `full_name`, `role`, `is_active`, `created_at`) VALUES
(1, 'admin', 'admin123', 'QCU Discipline Administrator', 'Admin', 1, '2026-11-27 23:27:28');

-- --------------------------------------------------------

--
-- Table structure for table `warnings`
--

CREATE TABLE `warnings` (
  `id` varchar(10) NOT NULL,
  `description` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `warnings`
--

INSERT INTO `warnings` (`id`, `description`) VALUES
('A', '1st Warning'),
('B', '2nd Warning'),
('C', '3rd Warning'),
('O', 'Others');

-- --------------------------------------------------------

--
-- Table structure for table `warning_specific`
--

CREATE TABLE `warning_specific` (
  `id` int(11) NOT NULL,
  `warning_id` varchar(10) NOT NULL,
  `description` varchar(255) NOT NULL,
  `has_community_service` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `warning_specific`
--

INSERT INTO `warning_specific` (`id`, `warning_id`, `description`, `has_community_service`) VALUES
(1, 'A', 'Written Warning / Reprimand', 0),
(2, 'A', 'Parent / Guardian Conference', 0),
(3, 'A', 'Community Service', 1),
(4, 'B', 'Parent / Guardian Conference', 0),
(5, 'B', 'Community Service', 1),
(6, 'B', 'Suspension (1 week)', 0),
(7, 'B', 'Suspension (1 week) w/ Community Service', 1),
(8, 'C', 'Disciplinary Board Referral', 0),
(9, 'C', 'Suspension (1 week)', 0),
(10, 'C', 'Suspension (1 week) w/ Community Service', 1),
(11, 'C', 'Suspension (2 weeks)', 0),
(12, 'C', 'Suspension (2 weeks) w/ Community Service', 1),
(13, 'A', 'Others', 0),
(14, 'B', 'Others', 0),
(15, 'C', 'Others', 0),
(16, 'O', 'Others', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `offense_attachments`
--
ALTER TABLE `offense_attachments`
  ADD PRIMARY KEY (`attachment_id`),
  ADD KEY `fk_attachments_log` (`log_id`);

--
-- Indexes for table `offense_category`
--
ALTER TABLE `offense_category`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `offense_logs`
--
ALTER TABLE `offense_logs`
  ADD PRIMARY KEY (`log_id`),
  ADD KEY `fk_logs_student` (`student_id`),
  ADD KEY `fk_logs_category` (`category_id`),
  ADD KEY `fk_logs_specific` (`specific_offense_id`),
  ADD KEY `fk_logs_warning` (`warning_id`);

--
-- Indexes for table `offense_specific`
--
ALTER TABLE `offense_specific`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_offense_specific_category` (`category_id`);

--
-- Indexes for table `sanctions`
--
ALTER TABLE `sanctions`
  ADD PRIMARY KEY (`sanction_id`),
  ADD KEY `fk_sanctions_log` (`log_id`),
  ADD KEY `fk_sanctions_wspec` (`warning_specific_id`);

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
-- Indexes for table `warnings`
--
ALTER TABLE `warnings`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `warning_specific`
--
ALTER TABLE `warning_specific`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_warning_specific_warning` (`warning_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `offense_attachments`
--
ALTER TABLE `offense_attachments`
  MODIFY `attachment_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `offense_logs`
--
ALTER TABLE `offense_logs`
  MODIFY `log_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `sanctions`
--
ALTER TABLE `sanctions`
  MODIFY `sanction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `offense_attachments`
--
ALTER TABLE `offense_attachments`
  ADD CONSTRAINT `fk_attachments_log` FOREIGN KEY (`log_id`) REFERENCES `offense_logs` (`log_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `offense_logs`
--
ALTER TABLE `offense_logs`
  ADD CONSTRAINT `fk_logs_category` FOREIGN KEY (`category_id`) REFERENCES `offense_category` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_logs_specific` FOREIGN KEY (`specific_offense_id`) REFERENCES `offense_specific` (`id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_logs_student` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_logs_warning` FOREIGN KEY (`warning_id`) REFERENCES `warnings` (`id`) ON UPDATE CASCADE;

--
-- Constraints for table `offense_specific`
--
ALTER TABLE `offense_specific`
  ADD CONSTRAINT `fk_offense_specific_category` FOREIGN KEY (`category_id`) REFERENCES `offense_category` (`id`) ON UPDATE CASCADE;

--
-- Constraints for table `sanctions`
--
ALTER TABLE `sanctions`
  ADD CONSTRAINT `fk_sanctions_log` FOREIGN KEY (`log_id`) REFERENCES `offense_logs` (`log_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_sanctions_wspec` FOREIGN KEY (`warning_specific_id`) REFERENCES `warning_specific` (`id`) ON DELETE SET NULL ON UPDATE CASCADE;

--
-- Constraints for table `warning_specific`
--
ALTER TABLE `warning_specific`
  ADD CONSTRAINT `fk_warning_specific_warning` FOREIGN KEY (`warning_id`) REFERENCES `warnings` (`id`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
