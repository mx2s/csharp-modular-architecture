<?php

use Phinx\Db\Adapter\MysqlAdapter;
use Phinx\Db\Adapter\PostgresAdapter;
use Phinx\Migration\AbstractMigration;

class CreateUsersTable extends AbstractMigration
{
    public function change()
    {
        $table = $this->table('users');
        $table->addColumn('login', 'string', [
        		'null' => false,
        	])
            ->addColumn('password', 'string')
            ->addColumn('email', 'string', [
            	'null' => false,
            ])
            ->addColumn('register_date', 'timestamp', [
            	'default' => 'CURRENT_TIMESTAMP'
            ])
            ->addIndex(['login', 'email'], ['unique' => true])
            ->create();
    }
}
