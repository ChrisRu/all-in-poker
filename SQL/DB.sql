CREATE TABLE person (
    id                  int                 NOT NULL AUTO_INCREMENT,
    first_name          varchar(80)         NOT NULL,
    last_name           varchar(80)         NOT NULL,
    middle_name         varchar(30)         NULL,
    gender              char(1)             NOT NULL,
    birth_date          date                NOT NULL,

    PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE person_phone (
    id                  int                 NOT NULL AUTO_INCREMENT,
    phone_number        char(12)            NOT NULL,

    PRIMARY KEY(id, phone_number),
    FOREIGN KEY(id)                         REFERENCES person(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


CREATE TABLE person_email (
    id                  int                 NOT NULL AUTO_INCREMENT,
    email_address       varchar(254)        NOT NULL,

    PRIMARY KEY(id, email_address),
    FOREIGN KEY(id)                         REFERENCES person(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE player (
    id                  int                 NOT NULL,
    postal_code         varchar(6)          NOT NULL,
    city                varchar(50)         NOT NULL,
    street              varchar(50)         NOT NULL,
    house_number        varchar(8)          NOT NULL,
    money_won           decimal(5,2)        NOT NULL DEFAULT 0.00,
    rating              int                 NULL,
    iban_number         varchar(30)         NOT NULL,

    PRIMARY KEY(id),
    FOREIGN KEY(id)                         REFERENCES person(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE professional (
    id                  int                 NOT NULL,
    nationality         varchar(40)         NOT NULL,

    PRIMARY KEY(id),
    FOREIGN KEY(id)                         REFERENCES person(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE event_location (
    id                  int                 NOT NULL AUTO_INCREMENT,
    max_players         int                 NOT NULL,
    postal_code         varchar(6)          NOT NULL,
    city                varchar(30)         NOT NULL,
    street              varchar(30)         NOT NULL,
    house_number        varchar(8)          NOT NULL,

    PRIMARY KEY(id)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE tournament (
    id                  int                 NOT NULL AUTO_INCREMENT,
    date                date                NOT NULL,
    time                time                NOT NULL,
    cost                decimal(5,2)        NOT NULL,
    min_players         int                 NOT NULL,
    min_age             int                 NOT NULL,
    max_age             int                 NOT NULL,
    location_id         int                 NULL,
    winner_id           int                 NULL,
    type                varchar(40)         NULL,

    PRIMARY KEY(id),
    FOREIGN KEY(winner_id)                  REFERENCES player(id) ON DELETE SET NULL ON UPDATE CASCADE,
    FOREIGN KEY(location_id)                REFERENCES event_location(id) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE tournament_entry (
    reference_number    int                 NOT NULL AUTO_INCREMENT,
    player_id           int                 NOT NULL,
    tournament_id       int                 NOT NULL,
    date                date                NOT NULL,
    has_paid            boolean             NOT NULL DEFAULT false,

    PRIMARY KEY(reference_number),
    FOREIGN KEY(player_id)                  REFERENCES player(id) ON DELETE CASCADE,
    FOREIGN KEY(tournament_id)              REFERENCES tournament(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE tournament_table (
    id                  int                 NOT NULL AUTO_INCREMENT,
    tournament_id       int                 NOT NULL,
    round               int                 NOT NULL DEFAULT 0,

    PRIMARY KEY(id),
    FOREIGN KEY(tournament_id)              REFERENCES tournament(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE tournament_table_player (
    table_id            int                 NOT NULL,
    player_id           int                 NOT NULL,
    position            int                 NOT NULL,

    PRIMARY KEY(table_id, player_id),
    FOREIGN KEY(table_id)                   REFERENCES tournament_table(id) ON DELETE CASCADE,
    FOREIGN KEY(player_id)                  REFERENCES player(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE masterclass (
    id                  int                 NOT NULL AUTO_INCREMENT,
    date                date                NOT NULL,
    time                time                NOT NULL,
    min_players         int                 NOT NULL,
    min_rating          int                 NOT NULL DEFAULT 0,
    location_id         int                 NULL,
    professional_id     int                 NULL,

    PRIMARY KEY(id),
    FOREIGN KEY(location_id)                REFERENCES event_location(id) ON DELETE SET NULL ON UPDATE CASCADE,
    FOREIGN KEY(professional_id)            REFERENCES professional(id) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE masterclass_entry (
    reference_number    int                 NOT NULL AUTO_INCREMENT,
    player_id           int                 NOT NULL,
    masterclass_id      int                 NOT NULL,
    date                date                NOT NULL,
    has_paid            boolean             NOT NULL DEFAULT false,

    PRIMARY KEY(reference_number),
    FOREIGN KEY(player_id)                  REFERENCES player(id) ON DELETE CASCADE,
    FOREIGN KEY(masterclass_id)             REFERENCES masterclass(id) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
