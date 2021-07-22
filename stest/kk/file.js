const testFolder = 'C:/ittra/Task2/tests';
const fs = require('fs');
var crypto = require('crypto');
fs.readdirSync(testFolder).forEach(file => {
let fileContent = fs.readFileSync(testFolder+"/"+file, "utf8");
var sha3 = crypto.createHash('sha3-256').update(fileContent).digest('hex');
console.log(file+" "+sha3);
});
