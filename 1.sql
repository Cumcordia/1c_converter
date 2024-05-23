CREATE TABLE files (
    id SERIAL PRIMARY KEY,
    filename TEXT,
    filedata BYTEA,
    upload_date TIMESTAMP with time zone
);

select * from files;
select * from "DataModel";
truncate "files";
drop table "DataModel";