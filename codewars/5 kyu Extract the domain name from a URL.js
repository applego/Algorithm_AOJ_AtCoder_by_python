
function domainName(url){
    //your code here

    const tmp1 = url.split('//').slice(-1)[0];
    const tmp2 = tmp1.split('www.').slice(-1)[0];
    const tmp3 = tmp2.split('.')[0];

    return tmp3;
//提出
    return url.split('//').slice(-1)[0].split('www.').slice(-1)[0].split('.')[0];
}

let test = require('./TestCodewar.js');
let Test = new test();
Test.assert_equals(domainName("http://google.com"), "google");
Test.assert_equals(domainName("http://google.co.jp"), "google");
Test.assert_equals(domainName("www.xakep.ru"), "xakep");
Test.assert_equals(domainName("https://youtube.com"), "youtube");
Test.assert_equals(domainName("http://www.codewars.com/kata/"), "codewars");
