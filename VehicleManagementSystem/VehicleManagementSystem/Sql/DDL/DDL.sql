--INSERT用、正規表現
--.\r\n
--\t

--DROP
DROP TABLE T_ACCOUNT;

DROP TABLE T_VEHICLE;

DROP TABLE T_USER;


-------------------------------------------------

--ID
--パスワード
--追加者
--追加日
--更新者
--更新日

--CREATE
CREATE TABLE T_ACCOUNT(
    ID varchar(50) NOT NULL,
    PASSWORD varchar(50) NOT NULL,
    INSERT_ID varchar(50) NOT NULL,
    INSERT_DATE_TIME datetime NOT NULL,
    UPDATE_ID varchar(50) NOT NULL,
    UPDATE_DATE_TIME datetime NOT NULL
    PRIMARY KEY(ID, PASSWORD)
);

-------------------------------------------------

--ユーザーID
--苗字
--名前
--苗字_かな
--名前_かな
--電話番号
--メールアドレス
--郵便番号
--住所
--追加者
--追加日
--更新者
--更新日

CREATE TABLE T_USER(
    USER_PK int NOT NULL IDENTITY(1, 1) PRIMARY KEY,
    SURNAME varchar(50) NULL,
    NAME varchar(50) NULL,
    PHONETIC_SURNAME varchar(50) NULL,
    PHONETIC_NAME varchar(50) NULL,
    PHONE_NUMBER varchar(50) NULL,
    MAIL_ADDRESS varchar(50) NULL,
    POSTAL_CODE varchar(50) NULL,
    STREET_ADDRESS varchar(200) NULL,
    INSERT_ID varchar(50) NULL,
    INSERT_DATE_TIME datetime NULL,
    UPDATE_ID varchar(50) NULL,
    UPDATE_DATE_TIME datetime NULL
);

-------------------------------------------------

--本拠地
--分類番号
--判別文字
--指定番号
--メーカー
--車名
--車台番号
--型式
--原動機型式
--型式指定番号
--類別番号
--走行距離
--初年度
--前回点検日
--次回点検日
--その他
--備考
--ユーザーID
--追加者
--追加日
--更新者
--更新日

CREATE TABLE T_VEHICLE(
    VEHICLE_PK int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    HOME varchar(50) NULL,
    CLASS_NUMBER varchar(50) NULL,
    DISCRIMINATION_CHARACTER varchar(50) NULL,
    DESIGNATED_NUMBER varchar(50) NULL,
    MANUFACTURER varchar(50) NULL,
    CAR_NAME varchar(50) NULL,
    CHASSIS_NUMBER varchar(50) NULL,
    MODEL varchar(50) NULL,
    PRIME_MOVER_MODEL varchar(50) NULL,
    MODEL_DESIGNATION_NUMBER varchar(50) NULL,
    CATEGORY_NUMBER varchar(50) NULL,
    MILEAGE varchar(50) NULL,
    FIRST_DATE date NULL,
    LAST_INSPECTION_DATE date NULL,
    NEXT_INSPECTION_DATE date NULL,
    OTHER varchar(50) NULL,
    REMARK varchar(1000) NULL,
    USER_PK int NOT NULL REFERENCES T_USER(USER_PK),
    INSERT_ID varchar(50) NULL,
    INSERT_DATE_TIME datetime NULL,
    UPDATE_ID varchar(50) NULL,
    UPDATE_DATE_TIME datetime NULL
);

-------------------------------------------------

--INSERT
INSERT INTO T_ACCOUNT(
    ID,
    PASSWORD,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    'Administrator',
    'Administrator',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);

INSERT INTO T_ACCOUNT(
    ID,
    PASSWORD,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    'user1',
    '1',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);

-------------------------------------------------

INSERT INTO T_USER(
    SURNAME,
    NAME,
    PHONETIC_SURNAME,
    PHONETIC_NAME,
    PHONE_NUMBER,
    MAIL_ADDRESS,
    POSTAL_CODE,
    STREET_ADDRESS,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    '三上',
    '悠亜',
    'みかみ',
    'ゆあ',
    0980000001,
    '1@abc',
    '000-0001',
    '沖縄県浦添市整理客072',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);

INSERT INTO T_USER(
    SURNAME,
    NAME,
    PHONETIC_SURNAME,
    PHONETIC_NAME,
    PHONE_NUMBER,
    MAIL_ADDRESS,
    POSTAL_CODE,
    STREET_ADDRESS,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    '三上',
    '不明',
    'みかみ',
    '不明',
    0980000002,
    '2@abc',
    '000-0002',
    '沖縄県浦添市整理客19',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);

INSERT INTO T_USER(
    SURNAME,
    NAME,
    PHONETIC_SURNAME,
    PHONETIC_NAME,
    PHONE_NUMBER,
    MAIL_ADDRESS,
    POSTAL_CODE,
    STREET_ADDRESS,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    '安齋',
    'らら',
    'あんざい',
    'らら',
    0980000003,
    '3@abc',
    '000-0003',
    '沖縄県浦添市整理客1919',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);

INSERT INTO T_USER(
    SURNAME,
    NAME,
    PHONETIC_SURNAME,
    PHONETIC_NAME,
    PHONE_NUMBER,
    MAIL_ADDRESS,
    POSTAL_CODE,
    STREET_ADDRESS,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    '漫湖',
    'らら',
    'まんこ',
    'らら',
    0980000004,
    '4@abc',
    '000-00043',
    '沖縄県浦添市整理客19194545',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);

INSERT INTO T_USER(
    SURNAME,
    NAME,
    PHONETIC_SURNAME,
    PHONETIC_NAME,
    PHONE_NUMBER,
    MAIL_ADDRESS,
    POSTAL_CODE,
    STREET_ADDRESS,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    '橋本',
    'ありな',
    'はしもと',
    'ありな',
    0980000005,
    '5@abc',
    '000-00043',
    '沖縄県浦添市整理客19190724545',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);

INSERT INTO T_USER(
    SURNAME,
    NAME,
    PHONETIC_SURNAME,
    PHONETIC_NAME,
    PHONE_NUMBER,
    MAIL_ADDRESS,
    POSTAL_CODE,
    STREET_ADDRESS,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    '石原',
    '希望',
    'いしはら',
    'のぞみ',
    0980000005,
    '5@abc',
    '000-00043',
    '沖縄県浦添市整理客19190724545315',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);

INSERT INTO T_USER(
    SURNAME,
    NAME,
    PHONETIC_SURNAME,
    PHONETIC_NAME,
    PHONE_NUMBER,
    MAIL_ADDRESS,
    POSTAL_CODE,
    STREET_ADDRESS,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    '二階堂',
    '夢',
    'にかいどう',
    'ゆめ',
    0980000005,
    '5@abc',
    '000-00043',
    '沖縄県浦添市整理客19190724545315',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);

-------------------------------------------------

INSERT INTO T_VEHICLE(
    HOME,
    CLASS_NUMBER,
    DISCRIMINATION_CHARACTER,
    DESIGNATED_NUMBER,
    MANUFACTURER,
    CAR_NAME,
    CHASSIS_NUMBER,
    MODEL,
    PRIME_MOVER_MODEL,
    MODEL_DESIGNATION_NUMBER,
    CATEGORY_NUMBER,
    MILEAGE,
    FIRST_DATE,
    LAST_INSPECTION_DATE,
    NEXT_INSPECTION_DATE,
    OTHER,
    REMARK,
    USER_PK,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    '沖縄',
    '300',
    'あ',
    '11-11',
    'レクサス',
    'LCコンバーチブル',
    '10',
    '20',
    '30',
    '40',
    '50',
    '60',
    '2020-07-14',
    '2020-07-14',
    '2020-07-14',
    '特になし',
    'あいうえお',
    '1',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);

INSERT INTO T_VEHICLE(
    HOME,
    CLASS_NUMBER,
    DISCRIMINATION_CHARACTER,
    DESIGNATED_NUMBER,
    MANUFACTURER,
    CAR_NAME,
    CHASSIS_NUMBER,
    MODEL,
    PRIME_MOVER_MODEL,
    MODEL_DESIGNATION_NUMBER,
    CATEGORY_NUMBER,
    MILEAGE,
    FIRST_DATE,
    LAST_INSPECTION_DATE,
    NEXT_INSPECTION_DATE,
    OTHER,
    REMARK,
    USER_PK,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    '沖縄',
    '300',
    'い',
    '11-12',
    'トヨタ',
    'プリウスPHV',
    '11',
    '21',
    '31',
    '41',
    '51',
    '61',
    '2020-07-14',
    '2020-07-14',
    '2020-07-14',
    '特になし',
    'かきくけこ',
    '1',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);

INSERT INTO T_VEHICLE(
    HOME,
    CLASS_NUMBER,
    DISCRIMINATION_CHARACTER,
    DESIGNATED_NUMBER,
    MANUFACTURER,
    CAR_NAME,
    CHASSIS_NUMBER,
    MODEL,
    PRIME_MOVER_MODEL,
    MODEL_DESIGNATION_NUMBER,
    CATEGORY_NUMBER,
    MILEAGE,
    FIRST_DATE,
    LAST_INSPECTION_DATE,
    NEXT_INSPECTION_DATE,
    OTHER,
    REMARK,
    USER_PK,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    '沖縄',
    '300',
    'う',
    '11-13',
    'ホンダ',
    'NSX',
    '12',
    '22',
    '32',
    '42',
    '52',
    '62',
    '2020-07-14',
    '2020-07-14',
    '2020-07-14',
    '特になし',
    'さしすせそ',
    '2',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);

INSERT INTO T_VEHICLE(
    HOME,
    CLASS_NUMBER,
    DISCRIMINATION_CHARACTER,
    DESIGNATED_NUMBER,
    MANUFACTURER,
    CAR_NAME,
    CHASSIS_NUMBER,
    MODEL,
    PRIME_MOVER_MODEL,
    MODEL_DESIGNATION_NUMBER,
    CATEGORY_NUMBER,
    MILEAGE,
    FIRST_DATE,
    LAST_INSPECTION_DATE,
    NEXT_INSPECTION_DATE,
    OTHER,
    REMARK,
    USER_PK,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    '沖縄',
    '300',
    'う',
    '11-13',
    '日産',
    'フーガハイブリッド',
    '13',
    '23',
    '33',
    '43',
    '53',
    '63',
    '2020-07-14',
    '2020-07-14',
    '2020-07-14',
    '特になし',
    'たちつてと',
    '3',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);

INSERT INTO T_VEHICLE(
    HOME,
    CLASS_NUMBER,
    DISCRIMINATION_CHARACTER,
    DESIGNATED_NUMBER,
    MANUFACTURER,
    CAR_NAME,
    CHASSIS_NUMBER,
    MODEL,
    PRIME_MOVER_MODEL,
    MODEL_DESIGNATION_NUMBER,
    CATEGORY_NUMBER,
    MILEAGE,
    FIRST_DATE,
    LAST_INSPECTION_DATE,
    NEXT_INSPECTION_DATE,
    OTHER,
    REMARK,
    USER_PK,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    '沖縄',
    '300',
    'え',
    '11-14',
    'スズキ',
    'ワゴンR',
    '14',
    '24',
    '34',
    '44',
    '54',
    '64',
    '2020-07-14',
    '2020-07-14',
    '2020-07-14',
    '特になし',
    'なにぬねの',
    '4',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);

INSERT INTO T_VEHICLE(
    HOME,
    CLASS_NUMBER,
    DISCRIMINATION_CHARACTER,
    DESIGNATED_NUMBER,
    MANUFACTURER,
    CAR_NAME,
    CHASSIS_NUMBER,
    MODEL,
    PRIME_MOVER_MODEL,
    MODEL_DESIGNATION_NUMBER,
    CATEGORY_NUMBER,
    MILEAGE,
    FIRST_DATE,
    LAST_INSPECTION_DATE,
    NEXT_INSPECTION_DATE,
    OTHER,
    REMARK,
    USER_PK,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    '沖縄',
    '300',
    'お',
    '11-15',
    'スズキ',
    'アルト',
    '15',
    '25',
    '35',
    '45',
    '55',
    '65',
    '2020-07-14',
    '2020-07-14',
    '2020-07-14',
    '特になし',
    'はひふへほ',
    '5',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);

INSERT INTO T_VEHICLE(
    HOME,
    CLASS_NUMBER,
    DISCRIMINATION_CHARACTER,
    DESIGNATED_NUMBER,
    MANUFACTURER,
    CAR_NAME,
    CHASSIS_NUMBER,
    MODEL,
    PRIME_MOVER_MODEL,
    MODEL_DESIGNATION_NUMBER,
    CATEGORY_NUMBER,
    MILEAGE,
    FIRST_DATE,
    LAST_INSPECTION_DATE,
    NEXT_INSPECTION_DATE,
    OTHER,
    REMARK,
    USER_PK,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    '沖縄',
    '300',
    'か',
    '11-13',
    'スバル',
    'フォレスター',
    '16',
    '26',
    '36',
    '46',
    '56',
    '66',
    '2020-07-14',
    '2020-07-14',
    '2020-07-14',
    '特になし',
    'まみむめも',
    '6',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);

INSERT INTO T_VEHICLE(
    HOME,
    CLASS_NUMBER,
    DISCRIMINATION_CHARACTER,
    DESIGNATED_NUMBER,
    MANUFACTURER,
    CAR_NAME,
    CHASSIS_NUMBER,
    MODEL,
    PRIME_MOVER_MODEL,
    MODEL_DESIGNATION_NUMBER,
    CATEGORY_NUMBER,
    MILEAGE,
    FIRST_DATE,
    LAST_INSPECTION_DATE,
    NEXT_INSPECTION_DATE,
    OTHER,
    REMARK,
    USER_PK,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    '沖縄',
    '300',
    'き',
    '11-16',
    'スバル',
    'WRX',
    '17',
    '27',
    '37',
    '47',
    '57',
    '67',
    '2020-07-14',
    '2020-07-14',
    '2020-07-14',
    '特になし',
    'やゆよ',
    '7',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);

INSERT INTO T_VEHICLE(
    HOME,
    CLASS_NUMBER,
    DISCRIMINATION_CHARACTER,
    DESIGNATED_NUMBER,
    MANUFACTURER,
    CAR_NAME,
    CHASSIS_NUMBER,
    MODEL,
    PRIME_MOVER_MODEL,
    MODEL_DESIGNATION_NUMBER,
    CATEGORY_NUMBER,
    MILEAGE,
    FIRST_DATE,
    LAST_INSPECTION_DATE,
    NEXT_INSPECTION_DATE,
    OTHER,
    REMARK,
    USER_PK,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    '沖縄',
    '300',
    'く',
    '11-17',
    'レクサス',
    'IS',
    '18',
    '28',
    '38',
    '48',
    '58',
    '68',
    '2020-07-14',
    '2020-07-14',
    '2020-07-14',
    '特になし',
    'らりるれろ',
    '7',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);

INSERT INTO T_VEHICLE(
    HOME,
    CLASS_NUMBER,
    DISCRIMINATION_CHARACTER,
    DESIGNATED_NUMBER,
    MANUFACTURER,
    CAR_NAME,
    CHASSIS_NUMBER,
    MODEL,
    PRIME_MOVER_MODEL,
    MODEL_DESIGNATION_NUMBER,
    CATEGORY_NUMBER,
    MILEAGE,
    FIRST_DATE,
    LAST_INSPECTION_DATE,
    NEXT_INSPECTION_DATE,
    OTHER,
    REMARK,
    USER_PK,
    INSERT_ID,
    INSERT_DATE_TIME,
    UPDATE_ID,
    UPDATE_DATE_TIME
)
VALUES(
    '沖縄',
    '300',
    'け',
    '11-18',
    '三菱',
    'デリカD：5',
    '10',
    '20',
    '30',
    '40',
    '50',
    '60',
    '2020-07-14',
    '2020-07-14',
    '2020-07-14',
    '特になし',
    'わをん',
    '7',
    'Administrator',
    '2020-07-14 00:00:00.000',
    'Administrator',
    '2020-07-14 00:00:00.000'
);
