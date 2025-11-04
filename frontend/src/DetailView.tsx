import { Card } from "@mui/material";
import type { Article } from "./article.types";

type DetailViewProps = {
    articles: Article[];
}

export const DetailView = ({articles}: DetailViewProps) => {
    return <>{articles.map(a => <Card key={a.id}>
        <img key={a.id} src={a.image}/>
    </Card>)}</>;
}