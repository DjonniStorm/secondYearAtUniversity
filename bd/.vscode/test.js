const { exec } = require('child_process');

const scripts = 
['D:\\dev_default\\uni\\bd\\create.pgsql',
'D:\\dev_default\\uni\\bd\\inserts.pgsql'];

const runScript = (script) => {
    return new Promise((resolve, reject) => {
        exec(`psql -U postgres -d postgres -h localhost -p 5432 -f ${script}`, (error, stdout, stderr) => {
            if (error) {
                reject(`Ошибка при выполнении ${script}: ${stderr}`);
            } else {
                console.log(`Результат выполнения ${script}: ${stdout}`);
                resolve();
            }
        });
    });
};

const runScriptsInOrder = async () => {
    for (const script of scripts) {
        await runScript(script);
    }
    console.log('Все скрипты выполнены.');
};

runScriptsInOrder().catch(console.error);
