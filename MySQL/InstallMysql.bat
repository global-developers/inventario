mysql -u root -e "CREATE DATABASE IF NOT EXISTS inventario CHARACTER SET latin1 COLLATE latin1_spanish_ci"
mysql -u root inventario -e "source inventario.sql"
