import { useEffect, useState } from 'react';

const MyComponents = (props) => {
    const [count, setCount] = useState(0);

    useEffect(() => {
        document.title = `Заголовок ${count}`
    })

    return (
        <div>
            <h1>{count}</h1>
            <button onClick={() => setCount(count + 1)}>Прибавить +1</button>
        </div>
    )
}

export default MyComponents;