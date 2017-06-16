USE allin_poker;

--
--
------------
-- Person --
------------
--
--

insert into person (first_name, last_name, gender, birth_date) values ('Kevina', 'Gouge', 'v', STR_TO_DATE('21/09/2000','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'testasdb@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, middle_name, last_name, gender, birth_date) values ('Crysta', 'van der', 'Gronous', 'm', STR_TO_DATE('21/09/1980','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Ruby', 'Lapidus', 'm', STR_TO_DATE('21/09/1950','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31615345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Marylynne', 'Topping', 'm', STR_TO_DATE('21/09/1970','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Denys', 'Wernham', 'm', STR_TO_DATE('21/09/1940','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Filippa', 'Gier', 'm', STR_TO_DATE('21/09/1999','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Weber', 'Fancy', 'm', STR_TO_DATE('21/09/1992','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Valeria', 'Ropp', 'm', STR_TO_DATE('21/09/1990','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Romy', 'Buckerfield', 'v', STR_TO_DATE('21/09/1995','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Norry', 'Flower', 'v', STR_TO_DATE('21/09/1997','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Deck', 'Wais', 'm', STR_TO_DATE('21/09/1990','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Erik', 'Romaynes', 'm', STR_TO_DATE('21/09/2000','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Cyrus', 'Shillum', 'm', STR_TO_DATE('21/09/1990','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Merrie', 'Westberg', 'v', STR_TO_DATE('21/09/1996','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Mallory', 'Stachini', 'm', STR_TO_DATE('21/09/1991','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Berty', 'Wennington', 'm', STR_TO_DATE('21/09/1980','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Marcus', 'Threadkell', 'm', STR_TO_DATE('21/09/1965','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Alexandro', 'Yerlett', 'm', STR_TO_DATE('21/09/1990','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Piggy', 'Creelman', 'm', STR_TO_DATE('21/09/2005','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Trista', 'Reeken', 'v', STR_TO_DATE('21/09/1960','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Pamelina', 'Bissatt', 'm', STR_TO_DATE('21/09/1980','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Mildred', 'Bumpass', 'm', STR_TO_DATE('21/09/1991','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Vannie', 'Burness', 'v', STR_TO_DATE('21/09/2003','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Ardys', 'Eustace', 'm', STR_TO_DATE('21/09/1997','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Lindsey', 'Botha', 'm', STR_TO_DATE('21/09/2001','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Bendite', 'Pegden', 'v', STR_TO_DATE('21/09/1982','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Les', 'Moorhead', 'm', STR_TO_DATE('21/09/1971','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Galven', 'Dilkes', 'm', STR_TO_DATE('21/09/1931','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'testtest@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Kerry', 'McOnie', 'v', STR_TO_DATE('21/09/1941','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Cindie', 'Mudd', 'v', STR_TO_DATE('21/09/1999','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'tes35t@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Emiline', 'Bicknell', 'm', STR_TO_DATE('21/09/1961','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into player(id, postal_code, city, street, house_number, iban_number, rating) values (LAST_INSERT_ID(), '2671GP', 'Zoetermeer', 'Straatnaamlaan', '10', 'NDL102494910', 1000);

insert into person (first_name, last_name, gender, birth_date) values ('Richardo', 'Foskett', 'm', STR_TO_DATE('21/09/1971','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test24@testmail.com');
insert into professional(id, nationality) values (LAST_INSERT_ID(), 'Nederlands');

insert into person (first_name, last_name, gender, birth_date) values ('Em', 'Millsom', 'm', STR_TO_DATE('21/09/1994','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into professional(id, nationality) values (LAST_INSERT_ID(), 'Nederlands');

insert into person (first_name, last_name, gender, birth_date) values ('Baxy', 'Biffen', 'v', STR_TO_DATE('21/09/1999','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into professional(id, nationality) values (LAST_INSERT_ID(), 'Engels');

insert into person (first_name, last_name, gender, birth_date) values ('Rogerio', 'Smittoune', 'v', STR_TO_DATE('21/09/1985','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into professional(id, nationality) values (LAST_INSERT_ID(), 'Nederlands');

insert into person (first_name, last_name, gender, birth_date) values ('Gris', 'Emig', 'v', STR_TO_DATE('21/09/1951','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345128');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into professional(id, nationality) values (LAST_INSERT_ID(), 'Nederlands');

insert into person (first_name, last_name, gender, birth_date) values ('Delila', 'Crock', 'v', STR_TO_DATE('21/09/1971','%d/%m/%Y'));
insert into person_phone(id, phone_number) values (LAST_INSERT_ID(), '+31612345678');
insert into person_email(id, email_address) values (LAST_INSERT_ID(), 'test@testmail.com');
insert into professional(id, nationality) values (LAST_INSERT_ID(), 'Duits');

--
--
--------------
-- Location --
--------------
--
--

insert into event_location (max_players, postal_code, city, street, house_number) values ('20', '1820AF', '‘Izrā', 'Truax', '3');
insert into event_location (max_players, postal_code, city, street, house_number) values ('10', '1234AB', 'Arroyito', 'Waywood', '32');
insert into event_location (max_players, postal_code, city, street, house_number) values ('25', '1820AF', 'Pasadena', 'Crest Line', '0643');
insert into event_location (max_players, postal_code, city, street, house_number) values ('60', '1234AB', 'Zhangxiong', 'Morningstar', '970');
insert into event_location (max_players, postal_code, city, street, house_number) values ('12', '1234AB', 'Nacka', 'Porter', '1');
insert into event_location (max_players, postal_code, city, street, house_number) values ('25', '2671GP', 'Särkisalo', 'Maple', '8574');
insert into event_location (max_players, postal_code, city, street, house_number) values ('64', '2671GP', 'Jintao', 'Meadow Ridge', '37269');
insert into event_location (max_players, postal_code, city, street, house_number) values ('30', '2671GP', 'Paris 11', 'Westridge', '173');
insert into event_location (max_players, postal_code, city, street, house_number) values ('20', '1820AF', 'Yilongyong', 'Kipling', '4');
insert into event_location (max_players, postal_code, city, street, house_number) values ('12', '1234AB', 'Lykóvrysi', 'Nancy', '02');
insert into event_location (max_players, postal_code, city, street, house_number) values ('60', '1920HD', 'Tianxin', 'Vera', '421');
insert into event_location (max_players, postal_code, city, street, house_number) values ('20', '2671GP', 'Shahrak', 'Oakridge', '46');
insert into event_location (max_players, postal_code, city, street, house_number) values ('15', '2671GP', 'Kárystos', 'Ilene', '2');
insert into event_location (max_players, postal_code, city, street, house_number) values ('10', '1920HD', 'Kota Kinabalu', 'Columbus', '2593');
insert into event_location (max_players, postal_code, city, street, house_number) values ('48', '2671GP', 'Buea', 'Oakridge', '8');
insert into event_location (max_players, postal_code, city, street, house_number) values ('48', '1920HD', 'Prestea', 'Anniversary', '866');
insert into event_location (max_players, postal_code, city, street, house_number) values ('30', '1820AF', 'Potolo', 'Kensington', '4');
insert into event_location (max_players, postal_code, city, street, house_number) values ('15', '1920HD', 'Wierzbica', 'Columbus', '7158');
insert into event_location (max_players, postal_code, city, street, house_number) values ('64', '1234AB', 'Bantawora', 'Surrey', '5');
insert into event_location (max_players, postal_code, city, street, house_number) values ('25', '1820AF', 'San Fernando del Valle', 'Arrowood', '5');
insert into event_location (max_players, postal_code, city, street, house_number) values ('36', '1820AF', 'Tbilisskaya', 'Namekagon', '98126');
insert into event_location (max_players, postal_code, city, street, house_number) values ('40', '1920HD', 'San Pablo', 'Swallow', '52641');
insert into event_location (max_players, postal_code, city, street, house_number) values ('64', '1920HD', 'Jiangdianzi', 'Prairieview', '41678');
insert into event_location (max_players, postal_code, city, street, house_number) values ('50', '1234AB', 'Västerås', 'Boyd', '2');
insert into event_location (max_players, postal_code, city, street, house_number) values ('50', '1920HD', 'Sandakan', 'Dovetail', '0');
insert into event_location (max_players, postal_code, city, street, house_number) values ('25', '1820AF', 'Cergy-Pontoise', 'Corben', '7590');
insert into event_location (max_players, postal_code, city, street, house_number) values ('20', '2671GP', 'Lahan Sai', 'Hanson', '7');
insert into event_location (max_players, postal_code, city, street, house_number) values ('20', '1820AF', 'Desa Wetan Ciakar', 'Eggendart', '555');
insert into event_location (max_players, postal_code, city, street, house_number) values ('10', '1920HD', 'Lopandino', 'Waxwing', '20072');
insert into event_location (max_players, postal_code, city, street, house_number) values ('25', '1920HD', 'Kurmanayevka', 'Pierstorff', '4918');
insert into event_location (max_players, postal_code, city, street, house_number) values ('60', '1820AF', 'Mayskiy', '1st', '112');
insert into event_location (max_players, postal_code, city, street, house_number) values ('60', '1920HD', 'Nishishinminato', 'Schiller', '71556');
insert into event_location (max_players, postal_code, city, street, house_number) values ('40', '1820AF', 'Goúvai', 'Paget', '38');
insert into event_location (max_players, postal_code, city, street, house_number) values ('10', '1234AB', 'Hisor', 'Village', '6');
insert into event_location (max_players, postal_code, city, street, house_number) values ('64', '1920HD', 'Xialiao', 'American Ash', '8218');
insert into event_location (max_players, postal_code, city, street, house_number) values ('50', '1820AF', 'San Antonio', 'Southridge', '75248');
insert into event_location (max_players, postal_code, city, street, house_number) values ('36', '1920HD', 'Huitán', 'Hooker', '9');
insert into event_location (max_players, postal_code, city, street, house_number) values ('52', '1234AB', 'Ayna', 'Meadow Vale', '73919');
insert into event_location (max_players, postal_code, city, street, house_number) values ('25', '1820AF', 'Jitian', 'Continental', '12696');
insert into event_location (max_players, postal_code, city, street, house_number) values ('52', '2671GP', 'Kỳ Anh', 'Village', '71');

--
--
----------------
-- Tournament --
----------------
--
--

insert into tournament (date, time, cost, min_players, min_age, max_age, location_id) values (STR_TO_DATE('21/09/2016','%d/%m/%Y'), NOW(), 8.61, 8, 21, 80, 3);
insert into tournament (date, time, cost, min_players, min_age, max_age, location_id) values (STR_TO_DATE('29/01/2017','%d/%m/%Y'), NOW(), 8.76, 4, 18, 60, 31);
insert into tournament (date, time, cost, min_players, min_age, max_age, location_id) values (STR_TO_DATE('12/11/2016','%d/%m/%Y'), NOW(), 7.11, 6, 18, 60, 10);
insert into tournament (date, time, cost, min_players, min_age, max_age, location_id) values (STR_TO_DATE('12/09/2016','%d/%m/%Y'), NOW(), 11.35, 6, 30, 100, 37);
insert into tournament (date, time, cost, min_players, min_age, max_age, location_id) values (STR_TO_DATE('24/11/2016','%d/%m/%Y'), NOW(), 10.31, 6, 18, 60, 36);
insert into tournament (date, time, cost, min_players, min_age, max_age, location_id) values (STR_TO_DATE('06/03/2017','%d/%m/%Y'), NOW(), 8.05, 6, 30, 100, 18);
insert into tournament (date, time, cost, min_players, min_age, max_age, location_id) values (STR_TO_DATE('18/07/2017','%d/%m/%Y'), NOW(), 6.90, 4, 21, 60, 17);
insert into tournament (date, time, cost, min_players, min_age, max_age, location_id) values (STR_TO_DATE('31/12/2016','%d/%m/%Y'), NOW(), 13.56, 4, 30, 80, 32);
insert into tournament (date, time, cost, min_players, min_age, max_age, location_id) values (STR_TO_DATE('23/06/2016','%d/%m/%Y'), NOW(), 7.58, 6, 30, 100, 15);
insert into tournament (date, time, cost, min_players, min_age, max_age, location_id) values (STR_TO_DATE('04/06/2017','%d/%m/%Y'), NOW(), 10.57, 4, 21, 80, 2);
insert into tournament (date, time, cost, min_players, min_age, max_age, location_id) values (STR_TO_DATE('30/03/2017','%d/%m/%Y'), NOW(), 11.19, 6, 8, 60, 21);
insert into tournament (date, time, cost, min_players, min_age, max_age, location_id) values (STR_TO_DATE('01/06/2017','%d/%m/%Y'), NOW(), 9.03, 8, 18, 60, 16);
insert into tournament (date, time, cost, min_players, min_age, max_age, location_id) values (STR_TO_DATE('14/07/2017','%d/%m/%Y'), NOW(), 13.04, 8, 18, 80, 19);

--
--
------------------------
-- Tournament Entries --
------------------------
--
--

insert into tournament_entry (player_id, tournament_id, date, has_paid) values (5, 1, STR_TO_DATE('25/09/2016','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (10, 1, STR_TO_DATE('20/05/2017','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (12, 1, STR_TO_DATE('28/06/2016','%d/%m/%Y'), true);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (7, 1, STR_TO_DATE('15/08/2016','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (1, 1, STR_TO_DATE('20/06/2016','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (13, 4, STR_TO_DATE('10/08/2016','%d/%m/%Y'), true);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (15, 3, STR_TO_DATE('11/03/2017','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (8, 1, STR_TO_DATE('08/12/2016','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (14, 5, STR_TO_DATE('29/12/2016','%d/%m/%Y'), true);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (3, 6, STR_TO_DATE('30/08/2016','%d/%m/%Y'), true);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (1, 2, STR_TO_DATE('25/09/2016','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (1, 3, STR_TO_DATE('20/05/2017','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (2, 5, STR_TO_DATE('28/06/2016','%d/%m/%Y'), true);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (3, 6, STR_TO_DATE('15/08/2016','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (4, 3, STR_TO_DATE('20/06/2016','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (5, 3, STR_TO_DATE('10/08/2016','%d/%m/%Y'), true);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (6, 3, STR_TO_DATE('11/03/2017','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (7, 9, STR_TO_DATE('08/12/2016','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (8, 4, STR_TO_DATE('29/12/2016','%d/%m/%Y'), true);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (1, 6, STR_TO_DATE('30/08/2016','%d/%m/%Y'), true);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (3, 8, STR_TO_DATE('30/08/2016','%d/%m/%Y'), true);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (1, 9, STR_TO_DATE('25/09/2016','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (1, 9, STR_TO_DATE('20/05/2017','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (2, 8, STR_TO_DATE('28/06/2016','%d/%m/%Y'), true);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (3, 11, STR_TO_DATE('15/08/2016','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (4, 12, STR_TO_DATE('20/06/2016','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (5, 11, STR_TO_DATE('10/08/2016','%d/%m/%Y'), true);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (6, 13, STR_TO_DATE('11/03/2017','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (7, 13, STR_TO_DATE('08/12/2016','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (8, 13, STR_TO_DATE('29/12/2016','%d/%m/%Y'), true);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (1, 11, STR_TO_DATE('30/08/2016','%d/%m/%Y'), true);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (4, 8, STR_TO_DATE('20/06/2016','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (5, 9, STR_TO_DATE('10/08/2016','%d/%m/%Y'), true);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (6, 8, STR_TO_DATE('11/03/2017','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (7, 7, STR_TO_DATE('08/12/2016','%d/%m/%Y'), false);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (8, 12, STR_TO_DATE('29/12/2016','%d/%m/%Y'), true);
insert into tournament_entry (player_id, tournament_id, date, has_paid) values (1, 13, STR_TO_DATE('30/08/2016','%d/%m/%Y'), true);



--
--
-----------------
-- Masterclass --
-----------------
--
--

insert into masterclass (date, time, min_players, location_id, min_rating, professional_id) values (NOW(), NOW(), 4, 3, 2246, 35);
insert into masterclass (date, time, min_players, location_id, min_rating, professional_id) values (NOW(), NOW(), 6, 16, 1909, 35);
insert into masterclass (date, time, min_players, location_id, min_rating, professional_id) values (NOW(), NOW(), 6, 8, 2782, 35);
insert into masterclass (date, time, min_players, location_id, min_rating, professional_id) values (NOW(), NOW(), 8, 13, 2932, 35);

--
--
-------------------------
-- Masterclass Entries --
-------------------------
--
--

insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (1, 1, STR_TO_DATE('25/09/2016','%d/%m/%Y'), false);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (11, 2, STR_TO_DATE('20/05/2017','%d/%m/%Y'), false);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (1, 3, STR_TO_DATE('28/06/2016','%d/%m/%Y'), true);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (2, 1, STR_TO_DATE('15/08/2016','%d/%m/%Y'), false);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (12, 2, STR_TO_DATE('20/06/2016','%d/%m/%Y'), false);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (2, 3, STR_TO_DATE('10/08/2016','%d/%m/%Y'), true);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (13, 1, STR_TO_DATE('11/03/2017','%d/%m/%Y'), false);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (3, 3, STR_TO_DATE('08/12/2016','%d/%m/%Y'), false);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (3, 4, STR_TO_DATE('29/12/2016','%d/%m/%Y'), true);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (4, 1, STR_TO_DATE('30/08/2016','%d/%m/%Y'), true);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (4, 2, STR_TO_DATE('25/09/2016','%d/%m/%Y'), false);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (15, 3, STR_TO_DATE('20/05/2017','%d/%m/%Y'), false);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (5, 3, STR_TO_DATE('28/06/2016','%d/%m/%Y'), true);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (6, 1, STR_TO_DATE('15/08/2016','%d/%m/%Y'), false);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (16, 2, STR_TO_DATE('20/06/2016','%d/%m/%Y'), false);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (6, 3, STR_TO_DATE('10/08/2016','%d/%m/%Y'), true);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (7, 1, STR_TO_DATE('11/03/2017','%d/%m/%Y'), false);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (7, 2, STR_TO_DATE('08/12/2016','%d/%m/%Y'), false);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (17, 3, STR_TO_DATE('29/12/2016','%d/%m/%Y'), true);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (8, 4, STR_TO_DATE('30/08/2016','%d/%m/%Y'), true);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (8, 2, STR_TO_DATE('25/09/2016','%d/%m/%Y'), false);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (19, 3, STR_TO_DATE('20/05/2017','%d/%m/%Y'), false);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (10, 2, STR_TO_DATE('28/06/2016','%d/%m/%Y'), true);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (10, 1, STR_TO_DATE('15/08/2016','%d/%m/%Y'), false);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (11, 1, STR_TO_DATE('20/06/2016','%d/%m/%Y'), false);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (14, 1, STR_TO_DATE('10/08/2016','%d/%m/%Y'), true);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (11, 4, STR_TO_DATE('11/03/2017','%d/%m/%Y'), false);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (17, 1, STR_TO_DATE('08/12/2016','%d/%m/%Y'), false);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (12, 1, STR_TO_DATE('29/12/2016','%d/%m/%Y'), true);
insert into masterclass_entry (player_id, masterclass_id, date, has_paid) values (10, 4, STR_TO_DATE('30/08/2016','%d/%m/%Y'), true);