import { Box } from "@mui/material";
import type { Article } from "./article.types";

type BottleViewProps = {
    articles: Article[];
}

export const BottleView = ({articles}: BottleViewProps) => {
    return <Box
        sx={{
            display: 'grid',
            gap: 2,
            gridTemplateColumns: 'repeat(auto-fill, minmax(160px, 1fr))',
        }}
        >
            {articles.map(a => <Box
            sx={{
                aspectRatio: '1 / 1',
                borderRadius: 2,
                bgcolor: 'grey.100',
                overflow: 'hidden',
                p: 1,
            }}
            key={a.id}>
                <Box
                component="img"
                src={a.image}
                sx={{
                    width: '100%',
                    height: '100%',
                    objectFit: 'contain',
                    display: 'block'
                }} />
            </Box>)}
    </Box>;
}