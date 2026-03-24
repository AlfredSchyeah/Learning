import { useEffect, useState } from 'react';
import axios from "axios";
import ContentItem from "./components/ContentItem";
import FooterItem from "./components/FooterItem";
import HeaderItem from "./components/HeaderItem";

const baseUrl = "https://jsonplaceholder.typicode.com/posts"

const HomePage = () => {
    const value = "Карточки с описанием";
    const [labels, setLabels] = useState([]);
    // const labels = [
    //     { id: 1, cardTitle: "Заголовок 1", cardText: "Описание 1" },
    //     { id: 2, cardTitle: "Заголовок 2", cardText: "Описание 2" },
    //     { id: 3, cardTitle: "Заголовок 3", cardText: "Описание 3" },
    // ]

    useEffect(() => {
        axios.get(baseUrl)
            .then(res => {
                const temp = [];
                res.data.slice(0, 5).forEach(
                    item => {
                        temp.push({
                            id: item.id,
                            cardTitle: item.title.slice(0, 10),
                            cardText: item.body,
                        }
                        )
                    }
                );
                setLabels(temp)
            });
    });

    return (
        <div className='container col-10'>
            <HeaderItem headerText={value} />
            <ContentItem
                setOfLabels={labels} />
            <FooterItem />
        </div>
    )
}

export default HomePage;