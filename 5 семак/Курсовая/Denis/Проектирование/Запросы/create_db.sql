



/* Удаление базы данных Restaurants*/
DROP DATABASE IF EXISTS restaurants; 
/* ------------ */




/* Создание базы данных Restaurants*/

CREATE DATABASE restaurants
CHARACTER SET utf8mb4
COLLATE utf8mb4_0900_ai_ci;

/* ------------ */



/*
1
Создание таблицы Должности - positions
Атрибуты:
  1) 'Код должности' BIGINT - id

  2) 'Название должности' VARCHAR(100) - title
  3) 'Описание должности' TEXT - description
  4) 'Образование для должности' VARCHAR(255) - education
  5) 'Должность являеется опасной' BOOL - is_dangerous
*/
CREATE TABLE restaurants.positions (
  id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Код должности',
  
  title VARCHAR(100) NOT NULL COMMENT 'Название должности',
  description TEXT DEFAULT NULL COMMENT 'Описание должности',
  education VARCHAR(255) DEFAULT NULL COMMENT 'Образование для должности',
  is_dangerous BOOL DEFAULT FALSE COMMENT 'Должность являеется опасной',
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'Должности';
/* ------------ */



/*
2
Создание таблицы График работы - schedule
Атрибуты:
  1) 'Код графика работы' BIGINT - id

  2) 'Время работы в понедельник' VARCHAR(13) - time_monday
  2) 'Время работы в вторник' VARCHAR(13) - time_tuesday
  3) 'Время работы в среда' VARCHAR(13) - time_wednesday
  4) 'Время работы в четверг' VARCHAR(13) - time_thursday
  5) 'Время работы в пятница' VARCHAR(13) - time_friday
  6) 'Время работы в суббота' VARCHAR(13) - time_saturday
  7) 'Время работы в воскресенье' VARCHAR(13) - time_sunday

Формат времени: 
Начало - конец
чч.мм - чч.мм
*/
CREATE TABLE restaurants.schedule (
  id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Код графика работы',
  
  time_monday VARCHAR(13) DEFAULT "08.00 - 18.00" COMMENT "Время работы в понедельник",
  time_tuesday VARCHAR(13) DEFAULT "08.00 - 18.00" COMMENT "Время работы в вторник",
  time_wednesday VARCHAR(13) DEFAULT "08.00 - 18.00" COMMENT "Время работы в среду",
  time_thursday VARCHAR(13) DEFAULT "08.00 - 18.00" COMMENT "Время работы в четверг",
  time_friday VARCHAR(13) DEFAULT "08.00 - 18.00" COMMENT "Время работы в пятницу",
  time_saturday VARCHAR(13) DEFAULT "08.00 - 18.00" COMMENT "Время работы в субботу",
  time_sunday VARCHAR(13) DEFAULT "08.00 - 18.00" COMMENT "Время работы в воскресенье",

  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'График работы';

/* ------------ */




/*
3
Создание таблицы Диапазон блюд - range_dishes
  1) 'Код блюда' BIGINT - id

  2) 'название' VARCHAR(100) - name
  3) 'Описание блюда' TEXT - describe
  4) 'Пригодно для упоребления несовершенолетними' BOOL - for_children
*/

CREATE TABLE restaurants.range_dishes (
  id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Код блюда',
  
  name VARCHAR(100) NOT NULL COMMENT "Название",
  `describe` TEXT COMMENT "Описание блюда",
  for_children BOOL DEFAULT TRUE COMMENT "Пригодно для упоребления несовершенолетними",

  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'Диапазон блюд';

/* ------------ */



/*
4(Ссылка на 2)
Создание таблицы Рестораны - restaurants
  1) 'Код ресторана' BIGINT - id

  2) 'название' VARCHAR(100) - name
  3) 'Оценка' FLOAT - mark_feedback
  4) 'адрес' VARCHAR(255) - address
  5) 'Количество звез мишлена' TINYINT - cout_star
  6) 'ID графика работы' BIGINT - id_schedule

*/
CREATE TABLE restaurants.restaurants (
  id BIGINT UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Код ресторана',
  
  name VARCHAR(100) NOT NULL COMMENT "Название",
  mark_feedback FLOAT DEFAULT 0 COMMENT "Оценка",
  address VARCHAR(255) NOT NULL COMMENT "Адрес",
  cout_star TINYINT DEFAULT 0 COMMENT "Количество звез мишлена",
  id_schedule BIGINT UNSIGNED NOT NULL COMMENT "Код графика работы",

  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'Рестораны';

ALTER TABLE restaurants.restaurants
ADD CONSTRAINT FK_restaurants_id_schedule FOREIGN KEY (id_schedule)
REFERENCES restaurants.schedule (id);


/* ------------ */


/*
4.1(ссылка на 1, 4)
Создание таблицы Работники - workers
  1) 'Код работника' - id
  2) 'ФИО' - name
  3) 'ID должности' - id_positions
  4) 'ID ресторана' - id_restaurants
  5) 'Описание' - describe
  6) 'Зарплата' - salary
  7) 'Дата рождения' - birthday_date

*/
CREATE TABLE restaurants.workers (
  id bigint UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Код работника',

  name varchar(100) NOT NULL COMMENT "ФИО",
  id_positions bigint UNSIGNED NOT NULL COMMENT "Код должности",
  id_restaurants bigint UNSIGNED NOT NULL COMMENT "Код ресторана",
  `describe`  text DEFAULT NULL COMMENT "Описание",
  salary int DEFAULT NULL COMMENT "Зарплата",
  birthday_date date DEFAULT NULL COMMENT "Дата рождения",
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'Работники';

ALTER TABLE restaurants.workers
ADD CONSTRAINT FK_workers_id_positions FOREIGN KEY (id_positions)
REFERENCES restaurants.positions (id);

ALTER TABLE restaurants.workers
ADD CONSTRAINT FK_workers_id_restaurants FOREIGN KEY (id_restaurants)
REFERENCES restaurants.restaurants (id);


/* ------------ */



/*
5(ссылка 3, 4)
Создание таблицы Позиции меню - menu_item
  1) 'Код Позиции меню' - id
  2) 'ID блюда' - id_range_dishes
  3) 'стоимость' - cost
  4) 'грамовка' - weight
  5) 'Наличие товара' - in_stock
  6) 'ID ресторана' - id_restaurants
*/

CREATE TABLE restaurants.menu_item (
  id bigint UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Код Позиции меню',

  id_range_dishes bigint UNSIGNED NOT NULL COMMENT 'Код блюда',
  cost int NOT NULL COMMENT 'стоимость',
  weight int COMMENT 'грамовка',
  id_restaurants bigint UNSIGNED NOT NULL COMMENT 'Код ресторана',
  in_stock BOOL DEFAULT TRUE COMMENT 'Наличие товара',
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'Позиции меню';

ALTER TABLE restaurants.menu_item
ADD CONSTRAINT FK_menu_item_id_range_dishes FOREIGN KEY (id_range_dishes)
REFERENCES restaurants.range_dishes (id);

ALTER TABLE restaurants.menu_item
ADD CONSTRAINT FK_menu_item_id_restaurants FOREIGN KEY (id_restaurants)
REFERENCES restaurants.restaurants (id);


/* ------------ */



/*
6
Создание таблицы Клиенты - clients
  1) 'Код клиента' - id
  2) 'ФИО' - name
  3) 'email' - email
  4) 'Дата рождения' - birthday_date
  5) 'Дата регистрации' - date_registration
*/
CREATE TABLE restaurants.clients (
  id bigint UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Код клиента',
  
  name varchar(100) NOT NULL COMMENT 'ФИО',
  email varchar(255) NOT NULL COMMENT 'email',
  birthday_date date DEFAULT NULL COMMENT 'Дата рождения',
  date_registration date DEFAULT NULL COMMENT 'Дата регистрации',
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'Клиенты';

/* ------------ */



/*
6.1(ссылка 5)
Создание таблицы Заказы - orders
  1) 'Код заказа' - id
  2) 'название' - name
  3) 'ID клиента' - id_clients
  4) 'Статус заказа' - state
  5) 'Дата заказа' - date
*/
CREATE TABLE restaurants.orders (
  id bigint UNSIGNED NOT NULL AUTO_INCREMENT COMMENT 'Код заказа',

  name varchar(100) COMMENT 'название',
  id_clients bigint UNSIGNED NOT NULL COMMENT 'Код клиента',
  state BOOL DEFAULT FALSE COMMENT 'Статус заказа',
  date date NOT NULL COMMENT 'Дата заказа',
  PRIMARY KEY (id)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'Заказы';

ALTER TABLE restaurants.orders
ADD CONSTRAINT FK_orders_id_clients FOREIGN KEY (id_clients)
REFERENCES restaurants.clients (id);

/* ------------ */


/*
7 (ссылка 5, 6.1)
Создание таблицы Заказаные блюда - order_dish
  1) 'Код заказа' - id_orders
  2) 'Код Позиции меню' - id_menu_item
*/
CREATE TABLE restaurants.order_dish (
  id_orders bigint UNSIGNED NOT NULL,
  id_menu_item bigint UNSIGNED NOT NULL
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'Заказаные блюда';

ALTER TABLE restaurants.order_dish
ADD CONSTRAINT FK_order_dish_id_menu_item FOREIGN KEY (id_menu_item)
REFERENCES restaurants.menu_item (id);

ALTER TABLE restaurants.order_dish
ADD CONSTRAINT FK_order_dish_id_orders FOREIGN KEY (id_orders)
REFERENCES restaurants.orders (id);

/* ------------ */