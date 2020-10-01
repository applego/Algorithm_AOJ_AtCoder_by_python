"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
var m1 = require("./8 kyu The falling speed of petals");
// m1.sakuraFall(0);
// m1.sakuraFall(5);
m1.sakuraFall(10);
// m1.sakuraFall(-1);
// m1.sakuraFall(200);
// console.log(m1.f(1000)); // "1,000円"
// console.log(m1.f2(1000)); // "1,000円"
// console.log(m1.f2(1000, 'ペソ')); // "1,000ペソ"
var TestCodewar_1 = __importDefault(require("./TestCodewar"));
var test = new TestCodewar_1.default(); //__filename
var isograms = require("./7 kyu Isograms");
test.assert_equals(isograms.isIsogram("Dermatoglyphics"), true); // isograms.isIsogram("Dermatoglyphics")//, true );
// test.assert_equals(isograms.isIsogram("isogram"), true );
// test.assert_equals(isograms.isIsogram("aba"), false, "same chars may not be adjacent" );
// test.assert_equals(isograms.isIsogram("moOse"), false, "same chars may not be same case" );
// test.assert_equals(isograms.isIsogram("isIsogram"), false );
// test.assert_equals(isograms.isIsogram(""), true, "an empty string is a valid isogram");
var _7_kyu_Vowel_Count_1 = require("./7 kyu Vowel Count");
test.assert_equals(_7_kyu_Vowel_Count_1.Kata.getCount("abracadabra"), 5);
var shark = require("./8 kyu Holiday VI - Shark Pontoon");
test.assert_equals(shark.shark(12, 50, 4, 8, true), "Alive!");
test.assert_equals(shark.shark(7, 55, 4, 16, true), "Alive!");
test.assert_equals(shark.shark(24, 0, 4, 8, true), "Shark Bait!");
test.assert_equals(shark.shark(40, 35, 3, 20, true), "Shark Bait!");
test.assert_equals(shark.shark(7, 8, 3, 4, true), "Alive!");
var nextid = require("./8 kyu Smallest unused ID");
test.assert_equals(nextid.nextId([0, 1, 2, 3, 5]), 4);
test.assert_equals(nextid.nextId([0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10]), 11);
var _8_kyu_Convert_a_Number_to_a_String_1 = require("./8 kyu Convert a Number to a String!");
test.assert_equals(_8_kyu_Convert_a_Number_to_a_String_1.numberToString(67), '67');
var _8_kyu_Convert_boolean_values_to_strings__Yes__or__No_1 = require("./8 kyu Convert boolean values to strings 'Yes' or 'No'");
test.assert_equals(_8_kyu_Convert_boolean_values_to_strings__Yes__or__No_1.boolToWord(true), "Yes");
test.assert_equals(_8_kyu_Convert_boolean_values_to_strings__Yes__or__No_1.boolToWord(false), "No");
var _8_kyu_Counting_sheep___1 = require("./8 kyu Counting sheep...");
var array1 = [true, true, true, false,
    true, true, true, true,
    true, false, true, undefined,
    true, false, null, true,
    true, true, true, true,
    false, false, true, true];
var result1 = _8_kyu_Counting_sheep___1.countSheeps(array1);
test.assert_equals(result1, 17, "There are 17 sheeps in total, not " + result1);
//# sourceMappingURL=main.js.map