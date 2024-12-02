-- Create/Insert Function
create or replace function karyawan_insert(
	_nama varchar,
	_id_dep int
)
returns int AS $$
begin
	insert into karyawan(nama, id_dep)
	values (_nama, _id_dep);
	if found then return 1;
	else return 0;
	end if;
end
$$ language plpgsql;

-- Select/Read
create or replace function karyawan_select()
returns table 
(
	_id_karyawan char,
	_nama varchar,
	_id_dep int,
	_nama_dep varchar
)
language plpgsql as $$
begin
	return query
	select id_karyawan, nama, id_dep, nama_dep from karyawan
	inner join departemen on id_dep = id_dep;
end
$$

-- Update/Edit
create or replace function karyawan_update(
    _id_karyawan char,
    _nama varchar,
    _id_dep int
)
returns int AS $$
begin
    update karyawan
    set nama = _nama, id_dep = _id_dep
    where id_karyawan = _id_karyawan;
    if found then return 1;
    else return 0;
    end if;
end
$$ language plpgsql;

-- Delete
create or replace function karyawan_delete(
    _id_karyawan char
)
returns int AS $$
begin
    delete from karyawan
    where id_karyawan = _id_karyawan;
    if found then return 1;
    else return 0;
    end if;
end
$$ language plpgsql;
