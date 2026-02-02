



/* Удаление базы данных Student*/

DROP DATABASE student; 

/* ------------ */




/* Создание базы данных Student*/

CREATE DATABASE Student
CHARACTER SET utf8mb4
COLLATE utf8mb4_0900_ai_ci;

/* ------------ */




/*
Создание таблицы специальности - Specialties
Атрибуты:
  1) `Код специальности` - id
  2) `Наименование специальности` - name
  3) `Описание специальности` - describe
*/

CREATE TABLE student.specialties (
  id bigint UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Код специальности',
  name varchar(50) DEFAULT NULL COMMENT 'Наименование специальности',
  `describe` text DEFAULT NULL COMMENT 'Описание специальности',
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'Cпециальности';

/* ------------ */



/*
Создание таблицы Дисциплины - Disciplines
Атрибуты:
  1) `Код дисциплины` - id
  2) `Наименование дисциплины` - name
  3) `Описание дисциплины` - describe

*/

CREATE TABLE student.disciplines (
  id  bigint UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Код дисциплины',
  name varchar(50) DEFAULT NULL COMMENT 'Наименование дисциплины',
  `describe` text DEFAULT NULL COMMENT 'Описание дисциплины',
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'Дисциплины';

/* ------------ */



/*
Создание таблицы студенты - students
Атрибуты:
  1) `Код студента` - id
  2) `ФИО` - name
  3) `Пол` - sex
  4) `Родители` - parents
  5) `Адрес` - address
  6) `Телефон` - phone_number
  7) `Паспортные данные` - passport_data
  8) `Группа` - group
  9) `Дата рождения` - birthday
  10) `Дата поступления` - date_receipt
  11) `Очная форма обучения` - is_full_time
  12) `Номер зачетки` - number_record_book
  13) `Курс` - nuber_course
  14) `Код специальности` - id_specialty

*/

CREATE TABLE student.students (
  id bigint UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Код студента',
  name varchar(50) DEFAULT NULL COMMENT 'ФИО',
  sex varchar(10) DEFAULT NULL COMMENT 'Пол',
  parents varchar(50) DEFAULT NULL COMMENT 'Родители',
  address text DEFAULT NULL COMMENT 'Адрес',
  phone_number varchar(15) DEFAULT NULL COMMENT 'Телефон',
  passport_data text DEFAULT NULL COMMENT 'Паспортные данные',
  `group` varchar(10) DEFAULT NULL COMMENT 'Группа',
  birthday datetime DEFAULT NULL COMMENT 'Дата рождения',
  date_receipt datetime DEFAULT NULL COMMENT 'Дата поступления',
  is_full_time tinyint(1) DEFAULT NULL COMMENT 'Очная форма обучения',
  number_record_book bigint DEFAULT NULL COMMENT 'Номер зачетки',
  nuber_course tinyint DEFAULT NULL COMMENT 'Курс',
  id_specialty bigint UNSIGNED NOT NULL COMMENT 'Код специальности',
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'Студенты';

ALTER TABLE student.students
ADD CONSTRAINT FK_students_id_specialty FOREIGN KEY (id_specialty)
REFERENCES student.specialties (id);

/* ------------ */


/*
Создадим таблицу Экзамены - exams
Атрибуты:
  1) `Код студента` - id_student
  2) `Код дисциплины` - id_discipline
  3) `Дата экзамена` - date
  4) `Оценка` - mark


*/

CREATE TABLE student.exams (
  id_student bigint UNSIGNED NOT NULL COMMENT 'Код студента',
  id_discipline bigint UNSIGNED NOT NULL COMMENT 'Код дисциплины',
  date datetime DEFAULT NULL COMMENT 'Дата экзамена',
  mark tinyint DEFAULT NULL COMMENT 'Оценка'
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'Экзамены';

ALTER TABLE student.exams
ADD CONSTRAINT FK_exams_id_discipline FOREIGN KEY (id_discipline)
REFERENCES student.disciplines (id);

ALTER TABLE student.exams
ADD CONSTRAINT FK_exams_id_student FOREIGN KEY (id_student)
REFERENCES student.students (id);


/* ------------ */