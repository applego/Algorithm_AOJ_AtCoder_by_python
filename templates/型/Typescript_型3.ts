/* 続き
// https://qiita.com/uhyo/items/e4f54ef3b87afdd65546?utm_content=buffer525a1&utm_medium=social&utm_source=facebook.com&utm_campaign=buffer&fbclid=IwAR0x2JkKQDEtSLd-qEoaBiL7TfetyMHHEX0Q7fjt7YN9_XtmMvDw29Qoegk
難易度：★★★☆　脱入門レベル
TypeScriptの型入門の内容をとりあえず知っていれば解ける問題たちです。

関数に適切な型を付ける問題では、型引数を自由に足して構いません。また、引数や返り値の型にアノテーションを施してもTypeScriptの型推論能力が足りずに関数内で型エラーが発生することがあります。その場合はasなどを用いて適宜エラーを回避しても構いません。

*/

/**
 3-1. 配列からMapを作る
以下のコードで定義される関数mapFromArrayは、オブジェクトの配列からMapを作って返す関数です。
配列から取り出した各オブジェクトをMapに登録しますが、その際にキーとして各オブジェクトの指定された
プロパティの値を用います。mapFromArrayに適切な型を付けてください。
 */
// my first answer(not correct)
//! interface mapArr { id: number, name: string; };

function mapFromArray<T,K extends keyof T>(arr:T[], key:K):Map<T[K],T> {
    const result = new Map();
    for (const obj of arr) {
        result.set(obj[key], obj);
    }
    return result;
}

// 使用例
const data = [
    { id: 1, name: "John Smith" },
    { id: 2, name: "Mary Sue" },
    { id: 100, name: "Taro Yamada" }
];
const dataMap = mapFromArray(data, "id");
/*
dataMapは
Map {
  1 => { id: 1, name: 'John Smith' },
  2 => { id: 2, name: 'Mary Sue' },
  100 => { id: 100, name: 'Taro Yamada' }
}
というMapになる
*/

// エラー例
// mapFromArray(data, "age");
