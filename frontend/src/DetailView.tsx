import { Box, Card, CardContent, Stack, Typography } from "@mui/material";
import type { Article } from "./article.types";

type DetailViewProps = {
    articles: Article[];
}

export const DetailView = ({articles}: DetailViewProps) => {
    return <>{articles.map(a => <Card key={a.id}>
        <CardContent>
            <Stack direction="row" spacing={2} alignItems="flex-start">
              <Box
                sx={{
                  width: { xs: 96, sm: 120, md: 140 },
                  aspectRatio: '1 / 1',
                  flex: '0 0 auto',
                  borderRadius: 2,
                  bgcolor: 'grey.100',
                  overflow: 'hidden',
                }}
              >
                <Box
                  component="img"
                  src={a.image}
                  alt={a.name}
                  loading="lazy"
                  decoding="async"
                  sx={{
                    width: '100%',
                    height: '100%',
                    objectFit: 'contain',
                    display: 'block',
                  }}
                />
              </Box>
              <Box sx={{ flex: 1, minWidth: 0 }}>
                <Typography variant="subtitle1" noWrap>{a.name}</Typography>
                <Typography variant="body2" color="text.secondary" sx={{ mb: 0.5 }}>
                  {a.price}
                </Typography>
                <Typography variant="body2">
                  {a.shortDescription}
                </Typography>
              </Box>
            </Stack>
        </CardContent>
    </Card>)}</>;
}