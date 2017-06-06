CREATE TABLE person (
	id				int				NOT NULL AUTO_INCREMENT,
	first_name 		varchar(30) 	NOT NULL,
	last_name 		varchar(30)		NOT NULL,
	middle_name 	varchar(30) 	DEFAULT '',
	gender 			char(1) 		NOT NULL,

	PRIMARY KEY(id),

	CHECK(gender='m' OR gender='v')
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE person_phone (
	id	 			int 			NOT NULL AUTO_INCREMENT,
	phone_number 	char(12) 		NOT NULL,

	PRIMARY KEY(id, phone_number),
	FOREIGN KEY(id)					REFERENCES person(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


CREATE TABLE person_email (
	id				int				NOT NULL AUTO_INCREMENT,
	email_address	varchar(30)		NOT NULL,

	PRIMARY KEY(id, email_address),
	FOREIGN KEY(id)					REFERENCES person(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE player (
	id				int				NOT NULL,
	postal_code		varchar(6) 		DEFAULT NULL,
	city 			varchar(30) 	DEFAULT NULL,
	street 			varchar(30) 	DEFAULT NULL,
	house_number 	int 			DEFAULT NULL,
	money_won		decimal(5,2)	DEFAULT 0.00,
	rating			int				DEFAULT NULL,
	iban_number		varchar(30)		DEFAULT NULL,

	PRIMARY KEY(id),
	FOREIGN KEY(id)					REFERENCES person(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE professional (
	id 				int				NOT NULL,
	nationality		varchar(20)		DEFAULT NULL,
	birth_date		date			DEFAULT NULL,

	PRIMARY KEY(id),
	FOREIGN KEY(id)					REFERENCES person(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE employee (
	id				int				NOT NULL,

	PRIMARY KEY(id),
	FOREIGN KEY(id)					REFERENCES person(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE event_location (
	id				int				NOT NULL AUTO_INCREMENT,
	max_players		smallint		DEFAULT NULL,
	postal_code		varchar(6) 		DEFAULT NULL,
	city 			varchar(30) 	DEFAULT NULL,
	street 			varchar(30) 	DEFAULT NULL,
	house_number 	int 			DEFAULT NULL,

	PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE tournament (
	id				int				NOT NULL AUTO_INCREMENT,
	date			date			NOT NULL,
	cost			decimal(5,2)	DEFAULT NULL,
	min_players		smallint		DEFAULT NULL,
	min_age			smallint		DEFAULT NULL,
	max_age			smallint		DEFAULT NULL,
	location_id		int				DEFAULT NULL,
	employee_id		int				DEFAULT NULL,
	winner			int				DEFAULT NULL,
	round			smallint		DEFAULT 0,

	PRIMARY KEY(id),
	FOREIGN KEY(winner) 			REFERENCES player(id) ON DELETE SET NULL ON UPDATE CASCADE,
	FOREIGN KEY(employee_id) 		REFERENCES employee(id) ON DELETE SET NULL ON UPDATE CASCADE,
	FOREIGN KEY(location_id) 		REFERENCES event_location(id) ON DELETE SET NULL ON UPDATE CASCADE,

	CHECK(min_age <= max_age)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE tournament_entry (
	player_id		int				NOT NULL,
	tournament_id	int				NOT NULL,
	date			date			DEFAULT NULL,
	has_paid		char(1)			DEFAULT 'n',

	PRIMARY KEY(player_id, tournament_id),
	FOREIGN KEY(player_id) 			REFERENCES player(id) ON DELETE CASCADE,
	FOREIGN KEY(tournament_id) 		REFERENCES tournament(id) ON DELETE CASCADE,

	CHECK(has_paid='y' OR has_paid='n')
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE tournament_table (
	id				int(6)			NOT NULL AUTO_INCREMENT,
	tournament_id	int(6) 			NOT NULL,

	PRIMARY KEY(id),
	FOREIGN KEY(tournament_id) 		REFERENCES tournament(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE tournament_table_players (
	table_id 		int 			NOT NULL,
	player_id 		int 			NOT NULL,

	PRIMARY KEY(table_id, player_id),
	FOREIGN KEY(table_id) 			REFERENCES tournament_table(id) ON DELETE CASCADE,
	FOREIGN KEY(player_id) 			REFERENCES player(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE masterclass (
	id				int				NOT NULL AUTO_INCREMENT,
	min_players		smallint		DEFAULT NULL,
	location_id 	int				DEFAULT NULL,
	min_rating		smallint		DEFAULT NULL,
	professional_id int				DEFAULT NULL,

	PRIMARY KEY(id),
	FOREIGN KEY(location_id)		REFERENCES event_location(id) ON DELETE SET NULL ON UPDATE CASCADE,
	FOREIGN KEY(professional_id)	REFERENCES professional(id) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE masterclass_entry (
	player_id		int				NOT NULL,
	masterclass_id	int				NOT NULL,
	date			date			DEFAULT NULL,
	has_paid		char(1)			DEFAULT 'n',

	PRIMARY KEY(player_id, masterclass_id),
	FOREIGN KEY(player_id) 			REFERENCES player(id) ON DELETE CASCADE,
	FOREIGN KEY(masterclass_id) 	REFERENCES masterclass(id) ON DELETE CASCADE,

	CHECK(has_paid='y' OR has_paid='n')
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
