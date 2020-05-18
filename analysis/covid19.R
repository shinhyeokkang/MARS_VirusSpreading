
human <- read.csv(file="../src-gen/Human.csv",head=T, sep=";", dec="." )

attach(human)

max_human_steps <- max(human$Step)

human_pop <- matrix(nrow = 1, ncol = max_human_steps)
human_rec <- matrix(nrow = 1, ncol = max_human_steps)

for (st in c(0:max_human_steps)) {
  human_pop[st] <- nrow(subset(human,Step==st&Infected=='True'))
}
for (st in c(0:max_human_steps)) {
  human_rec[st] <- nrow(subset(human,Step==st&Immune=='True'))
}
max_human <- max(human_pop)

jpeg(filename = "covid19.jpg",width = 800, height = 600)

plot(c(1:max(max_human_steps)), ylim = c(0,max_human), type = "n", 
     xlab ="Simulation steps", ylab = "Infected Population")

box()
lines(human_pop[1,],col="darkgrey")
lines(human_rec[1,],col="green")

abline(v=min(Government_announce_date),col="yellow",lty=2)
legend("topleft",legend=c("Infected","Recovered","SocialDistance"), col=c("darkgrey","green","yellow"), lty = 1)
dev.off()